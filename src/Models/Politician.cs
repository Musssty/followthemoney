namespace FollowTheMoney.Models;

public class Politician
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public string LastName { get; set; }
    public string ElectoralDivision { get; set; }
    public string State { get; set; }
    public DateTime Dob { get; set; }
    public DateTime TermStartDate { get; set; }
    public DateTime? TermEndDate { get; set; }
    public string Position { get; set; }
    public string CreatedDate { get; set; }
    public string UpdatedDate { get; set; }



    // Foreign Keys - these imply only one
    public int PoliticalPartyId { get; set; }

    // Navigation property for single relationships
    public PoliticalParty? PoliticalParty { get; set; }

    // Navigation properties for multiple relationships
    // navigation properties allow the querying of information much easier and other benefits that i dont understand
    public List<Organisation> Organisations { get; set; } = new();
    public List<Stock> Stocks { get; set; } = new();
    public List<Asset> Assets { get; set; } = new();
    public List<Donation> Donations { get; set; } = new();

    // just for convenience
    public string FullName => $"{FirstName} {LastName}";
}
