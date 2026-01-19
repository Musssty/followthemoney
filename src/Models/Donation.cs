namespace FollowTheMoney.Models;

public class Donation
{
    public int Id { get; set; }
    public double DonationsMadeValue { get; set; }
    public double DonationsReceivedValue { get; set; }
    public DateTime FinancialYear { get; set; }
    public DateTime DonationDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    
    public int OrganizationId { get; set; }
    public Organisation? Organisation { get; set; }
    
    public int PoliticalPartyId { get; set; }
    public PoliticalParty? PoliticalParty { get; set; }
    
}
