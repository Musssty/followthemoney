using FollowTheMoney.Models;

namespace FollowTheMoney.Services;

public class DummyDataService
{
    // Static GUIDs for parties
    private static readonly Guid AlpId = Guid.Parse("11111111-1111-1111-1111-111111111111");
    private static readonly Guid LibId = Guid.Parse("22222222-2222-2222-2222-222222222222");
    private static readonly Guid GrnId = Guid.Parse("33333333-3333-3333-3333-333333333333");

    // Static GUIDs for politicians
    private static readonly Guid AlbaneseId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa");
    private static readonly Guid DuttonId = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb");
    private static readonly Guid WongId = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc");
    private static readonly Guid BandtId = Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddddd");
    private static readonly Guid ChalmersId = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee");
    private static readonly Guid PlibersekId = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
    private static readonly Guid LeyId = Guid.Parse("00000000-0000-0000-0000-000000000001");
    private static readonly Guid MarlesId = Guid.Parse("00000000-0000-0000-0000-000000000002");

    // Method to get all parties
    public List<PoliticalParty> GetPoliticalParties()
    {
        return new List<PoliticalParty>
        {
            new PoliticalParty
            {
                Id = AlpId,
                Name = "Australian Labor Party",
                Abbreviation = "ALP",
                Founded = new DateTime(1901, 1, 1),
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            },
            new PoliticalParty
            {
                Id = LibId,
                Name = "Liberal Party of Australia",
                Abbreviation = "LIB",
                Founded = new DateTime(1944, 8, 31),
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            },
            new PoliticalParty
            {
                Id = GrnId,
                Name = "Australian Greens",
                Abbreviation = "GRN",
                Founded = new DateTime(1992, 8, 1),
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            }
        };
    }

    public List<Politician> GetPoliticians()
    {
        // Get parties first
        var parties = GetPoliticalParties();
        var alpParty = parties.First(p => p.Id == AlpId);
        var libParty = parties.First(p => p.Id == LibId);
        var grnParty = parties.First(p => p.Id == GrnId);

        return new List<Politician>
        {
            new Politician
            {
                Id = AlbaneseId,
                FirstName = "Anthony",
                LastName = "Albanese",
                ElectoralDivision = "Grayndler",
                State = "NSW",
                Dob = new DateTime(1963, 3, 2),
                TermStartDate = new DateTime(2022, 5, 23),
                TermEndDate = null,
                Position = "Prime Minister",
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                PoliticalPartyId = AlpId,
                PoliticalParty = alpParty
            },
            new Politician
            {
                Id = DuttonId,
                FirstName = "Peter",
                LastName = "Dutton",
                ElectoralDivision = "Dickson",
                State = "QLD",
                Dob = new DateTime(1970, 11, 18),
                TermStartDate = new DateTime(2001, 11, 10),
                TermEndDate = null,
                Position = "Opposition Leader",
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                PoliticalPartyId = LibId,
                PoliticalParty = libParty
            },
            new Politician
            {
                Id = WongId,
                FirstName = "Penny",
                LastName = "Wong",
                ElectoralDivision = "South Australia",
                State = "SA",
                Dob = new DateTime(1968, 11, 5),
                TermStartDate = new DateTime(2002, 7, 1),
                TermEndDate = null,
                Position = "Minister for Foreign Affairs",
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                PoliticalPartyId = AlpId,
                PoliticalParty = alpParty
            },
            new Politician
            {
                Id = BandtId,
                FirstName = "Adam",
                LastName = "Bandt",
                ElectoralDivision = "Melbourne",
                State = "VIC",
                Dob = new DateTime(1972, 3, 11),
                TermStartDate = new DateTime(2010, 8, 21),
                TermEndDate = null,
                Position = "Greens Leader",
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                PoliticalPartyId = GrnId,
                PoliticalParty = grnParty
            },
            new Politician
            {
                Id = ChalmersId,
                FirstName = "Jim",
                LastName = "Chalmers",
                ElectoralDivision = "Rankin",
                State = "QLD",
                Dob = new DateTime(1978, 3, 2),
                TermStartDate = new DateTime(2013, 9, 7),
                TermEndDate = null,
                Position = "Treasurer",
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                PoliticalPartyId = AlpId,
                PoliticalParty = alpParty
            },
            new Politician
            {
                Id = PlibersekId,
                FirstName = "Tanya",
                LastName = "Plibersek",
                ElectoralDivision = "Sydney",
                State = "NSW",
                Dob = new DateTime(1969, 12, 2),
                TermStartDate = new DateTime(1998, 10, 3),
                TermEndDate = null,
                Position = "Minister for the Environment and Water",
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                PoliticalPartyId = AlpId,
                PoliticalParty = alpParty
            },
            new Politician
            {
                Id = LeyId,
                FirstName = "Sussan",
                LastName = "Ley",
                ElectoralDivision = "Farrer",
                State = "NSW",
                Dob = new DateTime(1961, 12, 14),
                TermStartDate = new DateTime(2001, 11, 10),
                TermEndDate = null,
                Position = "Deputy Opposition Leader",
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                PoliticalPartyId = LibId,
                PoliticalParty = libParty
            },
            new Politician
            {
                Id = MarlesId,
                FirstName = "Richard",
                LastName = "Marles",
                ElectoralDivision = "Corio",
                State = "VIC",
                Dob = new DateTime(1967, 7, 13),
                TermStartDate = new DateTime(2007, 11, 24),
                TermEndDate = null,
                Position = "Deputy Prime Minister",
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                PoliticalPartyId = AlpId,
                PoliticalParty = alpParty
            }
        };
    }
}