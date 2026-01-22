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

<<<<<<< HEAD
    public List<PoliticianDonation> PoliticianDonations { get; set; } 
=======
    public List<PoliticianDonation> PoliticianDonations { get; set; } = new();
>>>>>>> 1566e645d8648ed45d622c6a5bcb52d50dbbf2d5
}
