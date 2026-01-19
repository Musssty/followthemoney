namespace FollowTheMoney.Models;

public class PoliticalParty
{
    public int Id { get; set; }
    public string Name { get; set; }           // ADD THIS LINE
    public string Abbreviation { get; set; }
    public DateTime Founded { get; set; }      // ADD THIS LINE if not there
    public string CreatedDate { get; set; }
    public string UpdatedDate { get; set; }

    // Remove these lines - wrong relationship
    // public int PoliticianId { get; set; }
    // public Politician? Politician { get; set; }

    // Add this - correct relationship
    public List<Politician> Politicians { get; set; } = new();
    
    public List<Donation> Donations { get; set; } = new();
}