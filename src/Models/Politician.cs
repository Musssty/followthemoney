namespace FollowTheMoney.Models;

public class Politician
{
    public Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? ElectoralDivision { get; set; }
    public string? State { get; set; }
    public DateTime Dob { get; set; }
    public DateTime TermStartDate { get; set; }
    public DateTime? TermEndDate { get; set; }
    public string? Position { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

    // Foreign key
    public Guid PoliticalPartyId { get; set; }
    public PoliticalParty? PoliticalParty { get; set; }

    // Many-to-many
    public List<PoliticianOrganisation> PoliticianOrganisations { get; set; } = new();
    public List<PoliticianDonation> PoliticianDonations { get; set; } = new();

    // One-to-many
    public List<Stock> Stocks { get; set; } = new();
    public List<Asset> Assets { get; set; } = new();
    public List<Gift> Gifts { get; set; } = new();

    public string FullName => $"{FirstName} {LastName}";
}
