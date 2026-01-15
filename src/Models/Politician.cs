namespace FollowTheMoney;

public class Politician {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName  { get; set; }
    public string ElectoralDivision  { get; set; }
    public string State { get; set; }

    // Foreign Keys
    public int OrganisationId { get; set; }
    public int StockHoldingId { get; set; }
    public int AssetId { get; set; }
    public int PoliticalPartyId { get; set; }

    // Navigation properties - ? this means it could be null setting it to this as idk yet need to think it through
    public Organisation? Organisation { get; set; }
    public StockHolding? StockHolding { get; set; }
    public Asset? Asset { get; set; }
    public PoliticalParty? PoliticalParty { get; set; }

    public string FullName => $"{FirstName} {LastName}";
}
