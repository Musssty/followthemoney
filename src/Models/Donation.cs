namespace FollowTheMoney.Models;

public class Donation
{
    public int Id { get; set; }
    public double Value { get; set; }
    public DateTime Date { get; set; }
    public string Type { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    
    public int OrganizationId { get; set; }
    public Organisation? Organisation { get; set; }
    
    public int PoliticalPartyId { get; set; }
    public PoliticalParty? PoliticalParty { get; set; }
    
    public int PoliticianId { get; set; }
    public Politician? Politician { get; set; }
}
