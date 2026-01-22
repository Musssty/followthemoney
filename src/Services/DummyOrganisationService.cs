using FollowTheMoney.Models;

namespace FollowTheMoney.Services;

public class DummyOrganisationService
{
    // Static GUIDs for organisations
    private static readonly Guid AwuId = Guid.Parse("10000000-0000-0000-0000-000000000001");
    private static readonly Guid BhpId = Guid.Parse("10000000-0000-0000-0000-000000000002");
    private static readonly Guid ClimateCouncilId = Guid.Parse("10000000-0000-0000-0000-000000000003");
    private static readonly Guid BcaId = Guid.Parse("10000000-0000-0000-0000-000000000004");
    private static readonly Guid AcfId = Guid.Parse("10000000-0000-0000-0000-000000000005");
    private static readonly Guid MasterBuildersId = Guid.Parse("10000000-0000-0000-0000-000000000006");
    private static readonly Guid AmaId = Guid.Parse("10000000-0000-0000-0000-000000000007");
    private static readonly Guid ActuId = Guid.Parse("10000000-0000-0000-0000-000000000008");
    private static readonly Guid MineralsCouncilId = Guid.Parse("10000000-0000-0000-0000-000000000009");
    private static readonly Guid GetUpId = Guid.Parse("10000000-0000-0000-0000-000000000010");

    public List<Organisation> GetOrganisations()
    {
        return new List<Organisation>
        {
            new Organisation
            {
                Id = AwuId,
                Name = "Australian Workers' Union",
                Industry = "Labour Union",
                Type = "Trade Union",
                Address = "133 Parramatta Road",
                City = "Granville",
                State = "NSW",
                Postcode = "2142",
                Website = "https://www.awu.net.au",
                CreatedDate = DateTime.UtcNow.AddYears(-5),
                UpdatedDate = DateTime.UtcNow
            },
            new Organisation
            {
                Id = BhpId,
                Name = "BHP Group",
                Industry = "Mining",
                Type = "Corporation",
                Address = "Level 18, 171 Collins Street",
                City = "Melbourne",
                State = "VIC",
                Postcode = "3000",
                Website = "https://www.bhp.com",
                CreatedDate = DateTime.UtcNow.AddYears(-10),
                UpdatedDate = DateTime.UtcNow
            },
            new Organisation
            {
                Id = ClimateCouncilId,
                Name = "Climate Council",
                Industry = "Environmental Advocacy",
                Type = "Non-Profit",
                Address = "Level 15, 179 Elizabeth Street",
                City = "Sydney",
                State = "NSW",
                Postcode = "2000",
                Website = "https://www.climatecouncil.org.au",
                CreatedDate = DateTime.UtcNow.AddYears(-8),
                UpdatedDate = DateTime.UtcNow
            },
            new Organisation
            {
                Id = BcaId,
                Name = "Business Council of Australia",
                Industry = "Business Advocacy",
                Type = "Industry Association",
                Address = "Level 3, 140 William Street",
                City = "Melbourne",
                State = "VIC",
                Postcode = "3000",
                Website = "https://www.bca.com.au",
                CreatedDate = DateTime.UtcNow.AddYears(-12),
                UpdatedDate = DateTime.UtcNow
            },
            new Organisation
            {
                Id = AcfId,
                Name = "Australian Conservation Foundation",
                Industry = "Environmental Conservation",
                Type = "Non-Profit",
                Address = "60 Leicester Street",
                City = "Carlton",
                State = "VIC",
                Postcode = "3053",
                Website = "https://www.acf.org.au",
                CreatedDate = DateTime.UtcNow.AddYears(-15),
                UpdatedDate = DateTime.UtcNow
            },
            new Organisation
            {
                Id = MasterBuildersId,
                Name = "Master Builders Australia",
                Industry = "Construction",
                Type = "Industry Association",
                Address = "Level 3, 44 Sydney Avenue",
                City = "Forrest",
                State = "ACT",
                Postcode = "2603",
                Website = "https://www.masterbuilders.com.au",
                CreatedDate = DateTime.UtcNow.AddYears(-7),
                UpdatedDate = DateTime.UtcNow
            },
            new Organisation
            {
                Id = AmaId,
                Name = "Australian Medical Association",
                Industry = "Healthcare",
                Type = "Professional Association",
                Address = "42 Macquarie Street",
                City = "Barton",
                State = "ACT",
                Postcode = "2600",
                Website = "https://www.ama.com.au",
                CreatedDate = DateTime.UtcNow.AddYears(-20),
                UpdatedDate = DateTime.UtcNow
            },
            new Organisation
            {
                Id = ActuId,
                Name = "Australian Council of Trade Unions",
                Industry = "Labour Union",
                Type = "Trade Union",
                Address = "Level 10, 365 Queen Street",
                City = "Melbourne",
                State = "VIC",
                Postcode = "3000",
                Website = "https://www.actu.org.au",
                CreatedDate = DateTime.UtcNow.AddYears(-18),
                UpdatedDate = DateTime.UtcNow
            },
            new Organisation
            {
                Id = MineralsCouncilId,
                Name = "Minerals Council of Australia",
                Industry = "Mining",
                Type = "Industry Association",
                Address = "Level 3, 44 Sydney Avenue",
                City = "Forrest",
                State = "ACT",
                Postcode = "2603",
                Website = "https://www.minerals.org.au",
                CreatedDate = DateTime.UtcNow.AddYears(-14),
                UpdatedDate = DateTime.UtcNow
            },
            new Organisation
            {
                Id = GetUpId,
                Name = "GetUp!",
                Industry = "Political Advocacy",
                Type = "Non-Profit",
                Address = "Level 5, 303 Elizabeth Street",
                City = "Sydney",
                State = "NSW",
                Postcode = "2000",
                Website = "https://www.getup.org.au",
                CreatedDate = DateTime.UtcNow.AddYears(-6),
                UpdatedDate = DateTime.UtcNow
            }
        };
    }
}