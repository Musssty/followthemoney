namespace FollowTheMoney.Models;

public class CommitteeMembership
{
    public Guid Id { get; set; }
    public DateTime MembershipStartDate { get; set; }
    public DateTime? MembershipEndDate { get; set; }
    public string? RoleInCommittee { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

     //Foreign key
    public Guid PoliticianId { get; set; } 
    public Politician? Politician { get; set; } 
    public Guid CommitteeId { get; set; } 
    public Committee? Committee { get; set; }
        
}