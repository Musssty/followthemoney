namespace FollowTheMoney.Models;

public class Donor
{
    public Guid Id { get; set; }
    public int DonorCode {get; set;}
    public required string Name { get; set; }
    public string? DonorDesciption { get; set; }
    public string? Type { get; set; }
    public double? TotalDonationsMade {get; set; }
    public double? TotalDonationsReceived { get; set; }

    //Foreign key
    public Guid DonationId { get; set; }
    public ICollection<Donation>? Donations { get; set; }

    //Sources to use
    //Donor Donations Received.csv
    //Donor Donations Made.csv

}