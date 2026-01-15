namespace FollowTheMoney;

public class Asset
{
    public int Id { get; set; }
    public string? Type { get; set; }
    public string? Description { get; set; }
    public double Value { get; set; }
    public DateTime AcquiredDate { get; set; }
    public DateTime DisposalDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

    public int PoliticianId { get; set; }
    public Politician? Politician { get; set; }
}
