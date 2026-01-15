namespace FollowTheMoney;

public class Politician {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName  { get; set; }
    public string ElectoralDivision  { get; set; }
    public string State { get; set; }
    public date DOB { get; set; }
    public date TermStartDate { get; set; }
    public date TermEndDate { get; set; }
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
    public List<StockHolding> StockHoldings { get; set; } = new();
    public List<Asset> Assets { get; set; } = new();

    // just for convenience
    public string FullName => $"{FirstName} {LastName}";
}
