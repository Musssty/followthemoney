namespace FollowTheMoney.Models;

public class Appointment
{
    public Guid Id { get; set; }
    public required string PositionTitle { get; set; }
    public string? Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool IsCurrent { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

    // Foreign key
    public Guid PoliticianId { get; set; }
    public GovOrg govOrg { get; set; } = null!;
    
}