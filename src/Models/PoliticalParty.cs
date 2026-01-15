namespace FollowTheMoney.Models;

public class PoliticalParty
{
    public int Id { get; set; }
    public string Abbreviation { get; set; }
    public string CreatedDate { get; set; }
    public string UpdatedDate { get; set; }

    public int PoliticianId { get; set; }
    public Politician? Politician { get; set; }

    public List<Donation> Donations { get; set; } = new();
}
