namespace FollowTheMoney.Models;

public class Stock
{
    public Guid Id { get; set; }
    public required string CompanyName { get; set; }
    public required string Ticker { get; set; }
    public int? Shares { get; set; }
    public double? Value { get; set; }
    public DateTime AcquiredDate { get; set; }
    public DateTime? DisposalDate { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }

    public Guid PoliticianId { get; set; }
    public Politician? Politician { get; set; }
}
