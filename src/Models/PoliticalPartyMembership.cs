namespace FollowTheMoney.Models;

public class PoliticalPartyMembership
{
    public Guid Id { get; set; }
    public DateTime MembershipStartDate { get; set; }
    public DateTime? MembershipEndDate { get; set; }
    public string? RoleInParty { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

     //Foreign key
     public Guid PoliticianId { get; set; } 
     public Politician? Politician { get; set; } 
     public Guid PoliticalPartyId { get; set; } 
     public PoliticalParty? PoliticalParty { get; set; }
}