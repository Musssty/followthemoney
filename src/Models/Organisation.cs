namespace FollowTheMoney;

public class Organisation
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Industry { get; set; }
    public required string Type { get; set; }
    public required string Address { get; set; }
    public required string City { get; set; }
    public required string State { get; set; }
    public required string Postcode { get; set; }
    public string? Website { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

    public List<Politician> Politicians { get; set; } = new();
    public List<PoliticalParty> PoliticalParties { get; set; } = new();
    //public List<Donation> Donations { get; set; } = new();

}
