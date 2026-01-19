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
                Id = 1,
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
                Id = 2,
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
                Id = 3,
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
                Id = 4,
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
                Id = 5,
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
                Id = 6,
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
                Id = 7,
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
                Id = 8,
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