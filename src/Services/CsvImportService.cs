using CsvHelper;
using CsvHelper.Configuration;
using FollowTheMoney.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Reflection;

namespace FollowTheMoney.Services;

public class CsvImportService
{
    private readonly IDbContextFactory<FollowTheMoneyDbContext> _contextFactory;

    public CsvImportService(IDbContextFactory<FollowTheMoneyDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    // Generic dynamic import method
    // Change the method signature - remove new() constraint
    public async Task<(int Success, List<string> Errors)> ImportFromCsv<T>(
    Stream csvStream,
    Dictionary<string, string> columnMapping,
    Dictionary<string, string> requiredFields) where T : class
{
    using var context = await _contextFactory.CreateDbContextAsync();
    
    // Create a memory stream to avoid sync reading issues
    var memoryStream = new MemoryStream();
    await csvStream.CopyToAsync(memoryStream);
    memoryStream.Position = 0;
    
    using var reader = new StreamReader(memoryStream);
    using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        HasHeaderRecord = true,
        TrimOptions = TrimOptions.Trim,
        MissingFieldFound = null,
        HeaderValidated = null
    });

    var entities = new List<T>();
    var errors = new List<string>();
    var rowNumber = 1;

    await csv.ReadAsync();
    csv.ReadHeader();
    var headers = csv.HeaderRecord ?? Array.Empty<string>();

    // Validate required fields are mapped
    foreach (var required in requiredFields)
    {
        if (string.IsNullOrEmpty(columnMapping.GetValueOrDefault(required.Key)))
        {
            errors.Add($"Required field '{required.Value}' is not mapped");
            return (0, errors);
        }
    }

    while (await csv.ReadAsync())
    {
        rowNumber++;
        try
        {
            T? entity = null;
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            
            // Collect all property values first
            var propertyValues = new Dictionary<PropertyInfo, object?>();

            foreach (var kvp in columnMapping.Where(m => !string.IsNullOrEmpty(m.Value)))
            {
                var propertyName = kvp.Key;
                var csvColumn = kvp.Value;

                var property = properties.FirstOrDefault(p => 
                    p.Name.Equals(propertyName, StringComparison.OrdinalIgnoreCase));

                if (property == null || !property.CanWrite)
                    continue;

                var value = GetMappedValue(csv, columnMapping, propertyName, headers);
                
                try
                {
                    var convertedValue = ConvertValue(property, value);
                    propertyValues[property] = convertedValue;
                }
                catch (Exception ex)
                {
                    errors.Add($"Row {rowNumber}, Column '{csvColumn}': {ex.Message}");
                }
            }

            // Try to create instance using constructor
            try
            {
                // Try parameterless constructor first
                entity = Activator.CreateInstance<T>();
            }
            catch
            {
                // If that fails, try to find and use a constructor with parameters
                var constructors = typeof(T).GetConstructors();
                
                if (constructors.Length > 0)
                {
                    var constructor = constructors[0];
                    var parameters = constructor.GetParameters();
                    var args = new object?[parameters.Length];
                    
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        var param = parameters[i];
                        var matchingProp = properties.FirstOrDefault(p => 
                            p.Name.Equals(param.Name, StringComparison.OrdinalIgnoreCase));
                        
                        if (matchingProp != null && propertyValues.ContainsKey(matchingProp))
                        {
                            args[i] = propertyValues[matchingProp];
                        }
                        else
                        {
                            args[i] = GetDefaultValue(param.ParameterType);
                        }
                    }
                    
                    entity = (T)constructor.Invoke(args);
                }
            }

            if (entity == null)
            {
                errors.Add($"Row {rowNumber}: Could not create instance of {typeof(T).Name}");
                continue;
            }

            // Set all property values
            foreach (var kvp in propertyValues)
            {
                try
                {
                    kvp.Key.SetValue(entity, kvp.Value);
                }
                catch (Exception ex)
                {
                    errors.Add($"Row {rowNumber}, Property '{kvp.Key.Name}': {ex.Message}");
                }
            }

            // Set default values for special fields
            SetDefaultValues(entity, properties);

            entities.Add(entity);
        }
        catch (Exception ex)
        {
            errors.Add($"Row {rowNumber}: {ex.Message}");
        }
    }

    if (entities.Any())
    {
        var dbSet = context.Set<T>();
        await dbSet.AddRangeAsync(entities);
        await context.SaveChangesAsync();
    }

    return (entities.Count, errors);
}

    private object? ConvertValue(PropertyInfo property, string value)
    {
        var propertyType = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;

        if (string.IsNullOrEmpty(value))
        {
            if (IsNullableType(property.PropertyType))
            {
                return null;
            }
            return GetDefaultValue(property.PropertyType);
        }

        try
        {
            if (propertyType == typeof(Guid))
            {
                return Guid.TryParse(value, out var guidValue) ? guidValue : Guid.Empty;
            }
            else if (propertyType == typeof(DateTime))
            {
                return DateTime.TryParse(value, out var dateValue) ? dateValue : DateTime.MinValue;
            }
            else if (propertyType == typeof(int))
            {
                return int.TryParse(value, out var intValue) ? intValue : 0;
            }
            else if (propertyType == typeof(decimal))
            {
                return decimal.TryParse(value, out var decimalValue) ? decimalValue : 0m;
            }
            else if (propertyType == typeof(bool))
            {
                return value.Equals("true", StringComparison.OrdinalIgnoreCase) ||
                       value.Equals("yes", StringComparison.OrdinalIgnoreCase) ||
                       value == "1";
            }
            else if (propertyType == typeof(List<string>))
            {
                return value.Split(',', ';')
                    .Select(s => s.Trim())
                    .Where(s => !string.IsNullOrEmpty(s))
                    .ToList();
            }
            else if (propertyType == typeof(string))
            {
                return value;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to convert value '{value}' to type {propertyType.Name}: {ex.Message}");
        }

        return GetDefaultValue(property.PropertyType);
    }

    private object? GetDefaultValue(Type type)
    {
        if (type.IsValueType)
        {
            return Activator.CreateInstance(type);
        }
        return null;
    }



    private void SetDefaultValues(object entity, PropertyInfo[] properties)
    {
        // Set Guid Id if empty
        var idProp = properties.FirstOrDefault(p => p.Name == "Id" && p.PropertyType == typeof(Guid));
        if (idProp != null && idProp.CanWrite)
        {
            var currentValue = (Guid?)idProp.GetValue(entity);
            if (currentValue == null || currentValue == Guid.Empty)
            {
                idProp.SetValue(entity, Guid.NewGuid());
            }
        }

        // Set CreatedDate if exists
        var createdProp = properties.FirstOrDefault(p => p.Name == "CreatedDate" && p.PropertyType == typeof(DateTime));
        if (createdProp != null && createdProp.CanWrite)
        {
            var currentValue = (DateTime?)createdProp.GetValue(entity);
            if (currentValue == null || currentValue == DateTime.MinValue)
            {
                createdProp.SetValue(entity, DateTime.UtcNow);
            }
        }

        // Set UpdatedDate if exists
        var updatedProp = properties.FirstOrDefault(p => p.Name == "UpdatedDate" && p.PropertyType == typeof(DateTime));
        if (updatedProp != null && updatedProp.CanWrite)
        {
            var currentValue = (DateTime?)updatedProp.GetValue(entity);
            if (currentValue == null || currentValue == DateTime.MinValue)
            {
                updatedProp.SetValue(entity, DateTime.UtcNow);
            }
        }
    }

    private bool IsNullableType(Type type)
    {
        return Nullable.GetUnderlyingType(type) != null ||
               !type.IsValueType ||
               type == typeof(string);
    }

    private string GetMappedValue(
        CsvReader csv,
        Dictionary<string, string> mapping,
        string modelField,
        string[] headers,
        bool required = false)
    {
        if (mapping.TryGetValue(modelField, out var csvColumn) && !string.IsNullOrEmpty(csvColumn))
        {
            if (headers.Contains(csvColumn))
            {
                return csv.GetField(csvColumn)?.Trim() ?? "";
            }
        }

        if (headers.Contains(modelField))
        {
            return csv.GetField(modelField)?.Trim() ?? "";
        }

        if (required)
        {
            throw new Exception($"Required field '{modelField}' not found in CSV");
        }

        return "";
    }

    // Get all properties of a type for dynamic mapping
    public List<PropertyMappingInfo> GetMappableProperties<T>()
    {
        var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(p => p.CanWrite && !IsNavigationProperty(p))
            .Select(p => new PropertyMappingInfo
            {
                PropertyName = p.Name,
                DisplayName = FormatDisplayName(p.Name),
                PropertyType = p.PropertyType,
                IsRequired = IsRequiredProperty(p),
                Description = GetPropertyDescription(p)
            })
            .OrderByDescending(p => p.IsRequired)
            .ThenBy(p => p.DisplayName)
            .ToList();

        return properties;
    }

    private bool IsNavigationProperty(PropertyInfo property)
    {
        // Skip navigation properties (collections and reference types that aren't primitives)
        if (property.PropertyType.IsGenericType &&
            property.PropertyType.GetGenericTypeDefinition() == typeof(List<>))
        {
            var genericArg = property.PropertyType.GetGenericArguments()[0];
            // Allow List<string> but not List<Entity>
            return genericArg != typeof(string);
        }

        // Skip single entity references (but allow string, DateTime, Guid, etc.)
        return property.PropertyType.IsClass &&
               property.PropertyType != typeof(string) &&
               property.PropertyType.Namespace?.StartsWith("FollowTheMoney.Models") == true;
    }

    private bool IsRequiredProperty(PropertyInfo property)
    {
        // Check for required attribute or non-nullable reference types
        return property.CustomAttributes.Any(a => a.AttributeType.Name == "RequiredAttribute") ||
               (property.PropertyType == typeof(string) &&
                property.CustomAttributes.Any(a => a.AttributeType.Name == "RequiredAttribute"));
    }

    private string FormatDisplayName(string propertyName)
    {
        // Convert PascalCase to "Pascal Case"
        return System.Text.RegularExpressions.Regex.Replace(propertyName,
            "(\\B[A-Z])", " $1");
    }

    public List<PropertyMappingInfo> GetMappableProperties(Type modelType)
    {
        var method = typeof(CsvImportService)
            .GetMethod(nameof(GetMappableProperties), 1, Type.EmptyTypes);

        if (method == null)
            throw new InvalidOperationException("Generic GetMappableProperties<T>() not found.");

        var generic = method.MakeGenericMethod(modelType);

        return (List<PropertyMappingInfo>)generic.Invoke(this, null)!;
    }


    private string? GetPropertyDescription(PropertyInfo property)
    {
        // Map common property names to descriptions
        var descriptions = new Dictionary<string, string>
        {
            { "Dob", "Date of Birth" },
            { "ABN", "Australian Business Number" },
            { "GFSSectorClass", "Government Finance Statistics Sector Class" },
            { "GFSFunctionSector", "Government Finance Statistics Function Sector" },
            { "PSActBody", "Public Service Act Body" },
            { "InternalDocId", "ID from source document" },
            { "TotalAppropriation", "Total Appropriation ($000)" },
            { "TotalDeptExpenses", "Total Department Expenses ($000)" },
            { "SourceDocument", "Comma-separated list of sources" }
        };

        return descriptions.GetValueOrDefault(property.Name);
    }
}

public class PropertyMappingInfo
{
    public string PropertyName { get; set; } = "";
    public string DisplayName { get; set; } = "";
    public Type PropertyType { get; set; } = typeof(string);
    public bool IsRequired { get; set; }
    public string? Description { get; set; }
}