using FollowTheMoney.Components;
using FollowTheMoney.Services;
using FollowTheMoney.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register the DummyDataService
builder.Services.AddScoped<DummyDataService>();
builder.Services.AddScoped<DummyOrganisationService>(); 
builder.Services.AddScoped<CsvImportService>();

// Add DbContext configuration
builder.Services.AddDbContextFactory<FollowTheMoneyDbContext>(options =>
    options.UseSqlite("Data Source=database.db"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();