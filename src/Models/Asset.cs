namespace FollowTheMoney.Models;

public class Asset
{
    public Guid Id { get; set; } 
    public required string Description { get; set; }
    public double? Value { get; set; }
    public DateTime AcquiredDate { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

    public Guid PoliticianId { get; set; }
    public Politician? Politician { get; set; }
}
