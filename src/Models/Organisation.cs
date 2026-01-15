namespace FollowTheMoney.Models;

public class Organisation
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Industry { get; set; }
    public string Type { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Postcode { get; set; }
    public string? Website { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

    public List<Politician> Politicians { get; set; } = new();
    public List<PoliticalParty> PoliticalParties { get; set; } = new();
    public List<Donation> Donations { get; set; } = new();

}
