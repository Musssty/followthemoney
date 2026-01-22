namespace FollowTheMoney.Models;

public class PoliticalParty
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Abbreviation { get; set; }
    public DateTime Founded { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

    public List<Politician> Politicians { get; set; } 
    public List<Donation> Donations { get; set; } 
    public List<OrganisationPoliticalParty> OrganisationPoliticalParties { get; set; } = new();  // ADD THIS LINE

}
