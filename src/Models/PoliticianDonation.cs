namespace FollowTheMoney.Models;

public class PoliticianDonation
{
    public Guid PoliticianId { get; set; }
    public required Politician Politician { get; set; }
    
    public Guid DonationId { get; set; }
    public required Donation Donation { get; set; }
}