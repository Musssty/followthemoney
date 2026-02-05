namespace FollowTheMoney.Models;

public class Committee
{
    public Guid Id { get; set; } //DB generated ID
    public string? CommitteeId {get; set; } // ID provided in the source document
    public required string CommitteeName {get; set; } /// Name of the Committee
    public string? CommitteeChamber {get; set; } // Chamber the Committee belongs to
    public string? CommitteeType {get; set; } // Type of Committee
    public DateTime ServiceStart {get; set; } // Date the Committee was established/created
    public DateTime? ServiceEnd {get; set; } // Date the Committee was dissolved (if applicable)
    public int? CurrentMembers {get; set; } // Number of current members
    public int? TotalMembers {get; set; } // Total number of members
    

    //Sources
    public List<string>? SourceDocument {get; set; } // List of source document URLs or references

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

    // Foreign key
    public ICollection<CommitteeMembership> Memberships { get; set; } = new List<CommitteeMembership>();

}