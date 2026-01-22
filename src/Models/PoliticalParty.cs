namespace FollowTheMoney.Models;

public class PoliticalParty
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Abbreviation { get; set; }
    public DateTime Founded { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

<<<<<<< HEAD
    public List<Politician> Politicians { get; set; } 
    public List<Donation> Donations { get; set; } 
    public List<OrganisationPoliticalParty> OrganisationPoliticalParties { get; set; } = new();  // ADD THIS LINE

=======
    public List<Politician> Politicians { get; set; } = new();
    public List<Donation> Donations { get; set; } = new();
>>>>>>> 1566e645d8648ed45d622c6a5bcb52d50dbbf2d5
}
