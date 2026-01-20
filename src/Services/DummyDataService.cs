using FollowTheMoney.Models;

namespace FollowTheMoney.Services;

public class DummyDataService
{
    public List<Politician> GetPoliticians()
    {
        return new List<Politician>
        {
            new Politician
            {
                Id = Guid.Parse("f3c1a8b2-9d44-4c2e-8f0b-1a2d9e7c4b11"),
                FirstName = "Anthony",
                LastName = "Albanese",
                ElectoralDivision = "Grayndler",
                State = "NSW",
                Dob = new DateTime(1963, 3, 2),
                TermStartDate = new DateTime(2022, 5, 23),
                TermEndDate = null,
                Position = "Prime Minister",
                CreatedDate = DateTime.Now.ToString(),
                UpdatedDate = DateTime.Now.ToString(),
                PoliticalPartyId = 1,
                PoliticalParty = new PoliticalParty 
                { 
                    Id = 1,
                    Name = "Australian Labor Party",
                    Abbreviation = "ALP",
                    Founded = new DateTime(1901, 1, 1),
                    CreatedDate = DateTime.Now.ToString(),
                    UpdatedDate = DateTime.Now.ToString()
                }
            },
            new Politician
            {
                Id = Guid.Parse("0a7d3f92-5b6e-4e8a-9c33-2f4b8d1e77aa"),
                FirstName = "Peter",
                LastName = "Dutton",
                ElectoralDivision = "Dickson",
                State = "QLD",
                Dob = new DateTime(1970, 11, 18),
                TermStartDate = new DateTime(2001, 11, 10),
                TermEndDate = null,
                Position = "Opposition Leader",
                CreatedDate = DateTime.Now.ToString(),
                UpdatedDate = DateTime.Now.ToString(),
                PoliticalPartyId = 2,
                PoliticalParty = new PoliticalParty 
                { 
                    Id = 2,
                    Name = "Liberal Party of Australia",
                    Abbreviation = "LIB",
                    Founded = new DateTime(1944, 8, 31),
                    CreatedDate = DateTime.Now.ToString(),
                    UpdatedDate = DateTime.Now.ToString()
                }
            },
            new Politician
            {
                Id = Guid.Parse("c4e8b1d0-2f9a-4c6b-8e55-91a0c3f4d2ef"),
                FirstName = "Penny",
                LastName = "Wong",
                ElectoralDivision = "South Australia",
                State = "SA",
                Dob = new DateTime(1968, 11, 5),
                TermStartDate = new DateTime(2002, 7, 1),
                TermEndDate = null,
                Position = "Minister for Foreign Affairs",
                CreatedDate = DateTime.Now.ToString(),
                UpdatedDate = DateTime.Now.ToString(),
                PoliticalPartyId = 1,
                PoliticalParty = new PoliticalParty 
                { 
                    Id = 1,
                    Name = "Australian Labor Party",
                    Abbreviation = "ALP",
                    Founded = new DateTime(1901, 1, 1),
                    CreatedDate = DateTime.Now.ToString(),
                    UpdatedDate = DateTime.Now.ToString()
                }
            },
            new Politician
            {
                Id = Guid.Parse("9b22e4c1-7f88-4d3a-bc10-5e6f7a8b9c01"),
                FirstName = "Adam",
                LastName = "Bandt",
                ElectoralDivision = "Melbourne",
                State = "VIC",
                Dob = new DateTime(1972, 3, 11),
                TermStartDate = new DateTime(2010, 8, 21),
                TermEndDate = null,
                Position = "Greens Leader",
                CreatedDate = DateTime.Now.ToString(),
                UpdatedDate = DateTime.Now.ToString(),
                PoliticalPartyId = 3,
                PoliticalParty = new PoliticalParty 
                { 
                    Id = 3,
                    Name = "Australian Greens",
                    Abbreviation = "GRN",
                    Founded = new DateTime(1992, 8, 1),
                    CreatedDate = DateTime.Now.ToString(),
                    UpdatedDate = DateTime.Now.ToString()
                }
            },
            new Politician
            {
                Id = Guid.Parse("1d4f8a77-3b2c-4e9d-8f11-0c9a7b6e5d44"),
                FirstName = "Jim",
                LastName = "Chalmers",
                ElectoralDivision = "Rankin",
                State = "QLD",
                Dob = new DateTime(1978, 3, 2),
                TermStartDate = new DateTime(2013, 9, 7),
                TermEndDate = null,
                Position = "Treasurer",
                CreatedDate = DateTime.Now.ToString(),
                UpdatedDate = DateTime.Now.ToString(),
                PoliticalPartyId = 1,
                PoliticalParty = new PoliticalParty 
                { 
                    Id = 1,
                    Name = "Australian Labor Party",
                    Abbreviation = "ALP",
                    Founded = new DateTime(1901, 1, 1),
                    CreatedDate = DateTime.Now.ToString(),
                    UpdatedDate = DateTime.Now.ToString()
                }
            },
            new Politician
            {
                Id = Guid.Parse("ab7c1e90-4f33-4d8e-9a22-7e5d1c0b3f88"),
                FirstName = "Tanya",
                LastName = "Plibersek",
                ElectoralDivision = "Sydney",
                State = "NSW",
                Dob = new DateTime(1969, 12, 2),
                TermStartDate = new DateTime(1998, 10, 3),
                TermEndDate = null,
                Position = "Minister for the Environment and Water",
                CreatedDate = DateTime.Now.ToString(),
                UpdatedDate = DateTime.Now.ToString(),
                PoliticalPartyId = 1,
                PoliticalParty = new PoliticalParty 
                { 
                    Id = 1,
                    Name = "Australian Labor Party",
                    Abbreviation = "ALP",
                    Founded = new DateTime(1901, 1, 1),
                    CreatedDate = DateTime.Now.ToString(),
                    UpdatedDate = DateTime.Now.ToString()
                }
            },
            new Politician
            {
                Id = Guid.Parse("e8d1c4a2-6b77-4f0e-8c99-2a1f5d3b7e66"),
                FirstName = "Sussan",
                LastName = "Ley",
                ElectoralDivision = "Farrer",
                State = "NSW",
                Dob = new DateTime(1961, 12, 14),
                TermStartDate = new DateTime(2001, 11, 10),
                TermEndDate = null,
                Position = "Deputy Opposition Leader",
                CreatedDate = DateTime.Now.ToString(),
                UpdatedDate = DateTime.Now.ToString(),
                PoliticalPartyId = 2,
                PoliticalParty = new PoliticalParty 
                { 
                    Id = 2,
                    Name = "Liberal Party of Australia",
                    Abbreviation = "LIB",
                    Founded = new DateTime(1944, 8, 31),
                    CreatedDate = DateTime.Now.ToString(),
                    UpdatedDate = DateTime.Now.ToString()
                }
            },
            new Politician
            {
                Id = Guid.Parse("3a9f0d11-8c44-4b2e-bf77-4d0a9c1e2b55"),
                FirstName = "Richard",
                LastName = "Marles",
                ElectoralDivision = "Corio",
                State = "VIC",
                Dob = new DateTime(1967, 7, 13),
                TermStartDate = new DateTime(2007, 11, 24),
                TermEndDate = null,
                Position = "Deputy Prime Minister",
                CreatedDate = DateTime.Now.ToString(),
                UpdatedDate = DateTime.Now.ToString(),
                PoliticalPartyId = 1,
                PoliticalParty = new PoliticalParty 
                { 
                    Id = 1,
                    Name = "Australian Labor Party",
                    Abbreviation = "ALP",
                    Founded = new DateTime(1901, 1, 1),
                    CreatedDate = DateTime.Now.ToString(),
                    UpdatedDate = DateTime.Now.ToString()
                }
            }
        };
    }
}