namespace FollowTheMoney.Models;

public class PoliticalParty
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Abbreviation { get; set; }
    public DateTime Founded { get; set; }  // Add this
    public string CreatedDate { get; set; }
    public string UpdatedDate { get; set; }

    // Navigation property for multiple politicians
    public List<Politician> Politicians { get; set; } = new();
    
    public List<Donation> Donations { get; set; } = new();
}