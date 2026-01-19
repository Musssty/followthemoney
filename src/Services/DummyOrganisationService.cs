using FollowTheMoney.Models;

namespace FollowTheMoney.Services;

public class DummyOrganisationService
{
    public List<Organisation> GetOrganisations()
    {
        return new List<Organisation>
        {
            new Organisation
            {
                Id = 1,
                Name = "Australian Workers' Union",
                Industry = "Labour Union",
                Type = "Trade Union",
                Address = "133 Parramatta Road",
                City = "Granville",
                State = "NSW",
                Postcode = "2142",
                Website = "https://www.awu.net.au",
                CreatedDate = DateTime.Now.AddYears(-5),
                UpdatedDate = DateTime.Now
            },
            new Organisation
            {
                Id = 2,
                Name = "BHP Group",
                Industry = "Mining",
                Type = "Corporation",
                Address = "Level 18, 171 Collins Street",
                City = "Melbourne",
                State = "VIC",
                Postcode = "3000",
                Website = "https://www.bhp.com",
                CreatedDate = DateTime.Now.AddYears(-10),
                UpdatedDate = DateTime.Now
            },
            new Organisation
            {
                Id = 3,
                Name = "Climate Council",
                Industry = "Environmental Advocacy",
                Type = "Non-Profit",
                Address = "Level 15, 179 Elizabeth Street",
                City = "Sydney",
                State = "NSW",
                Postcode = "2000",
                Website = "https://www.climatecouncil.org.au",
                CreatedDate = DateTime.Now.AddYears(-8),
                UpdatedDate = DateTime.Now
            },
            new Organisation
            {
                Id = 4,
                Name = "Business Council of Australia",
                Industry = "Business Advocacy",
                Type = "Industry Association",
                Address = "Level 3, 140 William Street",
                City = "Melbourne",
                State = "VIC",
                Postcode = "3000",
                Website = "https://www.bca.com.au",
                CreatedDate = DateTime.Now.AddYears(-12),
                UpdatedDate = DateTime.Now
            },
            new Organisation
            {
                Id = 5,
                Name = "Australian Conservation Foundation",
                Industry = "Environmental Conservation",
                Type = "Non-Profit",
                Address = "60 Leicester Street",
                City = "Carlton",
                State = "VIC",
                Postcode = "3053",
                Website = "https://www.acf.org.au",
                CreatedDate = DateTime.Now.AddYears(-15),
                UpdatedDate = DateTime.Now
            },
            new Organisation
            {
                Id = 6,
                Name = "Master Builders Australia",
                Industry = "Construction",
                Type = "Industry Association",
                Address = "Level 3, 44 Sydney Avenue",
                City = "Forrest",
                State = "ACT",
                Postcode = "2603",
                Website = "https://www.masterbuilders.com.au",
                CreatedDate = DateTime.Now.AddYears(-7),
                UpdatedDate = DateTime.Now
            },
            new Organisation
            {
                Id = 7,
                Name = "Australian Medical Association",
                Industry = "Healthcare",
                Type = "Professional Association",
                Address = "42 Macquarie Street",
                City = "Barton",
                State = "ACT",
                Postcode = "2600",
                Website = "https://www.ama.com.au",
                CreatedDate = DateTime.Now.AddYears(-20),
                UpdatedDate = DateTime.Now
            },
            new Organisation
            {
                Id = 8,
                Name = "Australian Council of Trade Unions",
                Industry = "Labour Union",
                Type = "Trade Union",
                Address = "Level 10, 365 Queen Street",
                City = "Melbourne",
                State = "VIC",
                Postcode = "3000",
                Website = "https://www.actu.org.au",
                CreatedDate = DateTime.Now.AddYears(-18),
                UpdatedDate = DateTime.Now
            },
            new Organisation
            {
                Id = 9,
                Name = "Minerals Council of Australia",
                Industry = "Mining",
                Type = "Industry Association",
                Address = "Level 3, 44 Sydney Avenue",
                City = "Forrest",
                State = "ACT",
                Postcode = "2603",
                Website = "https://www.minerals.org.au",
                CreatedDate = DateTime.Now.AddYears(-14),
                UpdatedDate = DateTime.Now
            },
            new Organisation
            {
                Id = 10,
                Name = "GetUp!",
                Industry = "Political Advocacy",
                Type = "Non-Profit",
                Address = "Level 5, 303 Elizabeth Street",
                City = "Sydney",
                State = "NSW",
                Postcode = "2000",
                Website = "https://www.getup.org.au",
                CreatedDate = DateTime.Now.AddYears(-6),
                UpdatedDate = DateTime.Now
            }
        };
    }
}