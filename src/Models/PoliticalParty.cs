namespace FollowTheMoney.Models;    

public class PoliticalParty
{
    public Guid Id { get; set; }
    public int PartyCode { get; set; }
    public required string Name { get; set; }
    public required string Abbreviation { get; set; }
    public DateTime FoundedDate { get; set; }
    public DateTime? DissolvedDate { get; set; }
    public string? Description { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

    //Foreign key
    public ICollection<PoliticalPartyMembership> Memberships { get; set; } = new List<PoliticalPartyMembership>();
}