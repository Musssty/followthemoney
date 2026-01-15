namespace FollowTheMoney;

public class Stock
{
    public int Id { get; set; }
    public required string CompanyName { get; set; }
    public required string Ticker { get; set; }
    public int? Shares { get; set; }
    public double? Value { get; set; }
    public DateTime AcquiredDate { get; set; }
    public DateTime? DisposalDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }

    public int PoliticianId { get; set; }
    public Politician? Politician { get; set; }
}
