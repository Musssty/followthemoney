namespace FollowTheMoney.Models;

public class Donation
{
    public Guid Id { get; set; }
    public double Amount { get; set; }
    public DateTime DonationDate { get; set; }
    public DateTime FinancialYear { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

    public Guid OrganisationId { get; set; }
    public Organisation? Organisation { get; set; }

    public Guid PoliticalPartyId { get; set; }
    public PoliticalParty? PoliticalParty { get; set; }

    public List<PoliticianDonation> PoliticianDonations { get; set; } = new();
}
