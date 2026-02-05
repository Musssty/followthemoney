namespace FollowTheMoney.Models;

public class Electorate
{
    public Guid Id { get; set; }
    public int ElectorateCode { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? ElectorateAddress1 { get; set; }
    public string? ElectorateAddress2 { get; set; }
    public string? ElectorateSuburb { get; set; }
    public string? ElectorateState { get; set; }
    public string? ElectoratePostcode { get; set; }
    public string? ElectorateTelephone { get; set; }
    public string? ElectorateFax { get; set; }
    public string? ElectorateTollFree { get; set; }
    public string? ElectoratePostalAddress1 { get; set; }
    public string? ElectoratePostalAddress2 { get; set; }
    public string? ElectoratePostalSuburb { get; set; }
    public string? ElectoratePostalState { get; set; }
    public string? ElectoratePostalPostcode { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

    //Foreign key
    public ICollection<Politician>? Politicians { get; set; }
}