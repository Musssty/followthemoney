namespace FollowTheMoney.Models;

public class Donation
{
    public Guid Id { get; set; }
    public double Value { get; set; }
    public DateTime DonationDate { get; set; }
    public DateTime FinancialYear { get; set; }
    public string? DonationTo { get; set; }
    public string? DonationFrom { get; set; }
    public string? Event { get; set; }
    public string? ReturnType { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
    
    //Foreign key
    public Guid OrganisationId { get; set; }
    public Organisation? Organisation { get; set; }
    public Guid PoliticalPartyId { get; set; }
    public PoliticalParty? PoliticalParty { get; set; }
    public Guid DonorId { get; set; }
    public Donor? Donor { get; set; }

    



    //Sources used
    //Donor Donations Received.csv
    //Donor Donations Made.csv
    //Senate Goups and Candidate Donations.cs
    //
}
