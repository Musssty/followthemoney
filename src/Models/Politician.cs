namespace FollowTheMoney.Models;    


public class Politician
{
    public Guid Id { get; set; }
    public string? Honorific { get; set; }
    public string? Salutation { get; set; }
    public string? PostNominals { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? OtherName { get; set; }
    public string? PreferredName { get; set; }
    public string? Initials { get; set; }
    public string? State { get; set; }
    public string? PoliticalParty { get; set; }
    public string? Gender { get; set; }
    public string? Telephone { get; set; }
    public string? ParliamentaryTitle { get; set; }
    public string? MinisterialTitle { get; set; }


    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

    // Foreign key
    // Normalized foreign keys 
    public Guid? ElectorateId { get; set; } 
    public Electorate? ElectorateRef { get; set; } // Many-to-many via PoliticalPartyMembership 
    public ICollection<PoliticalPartyMembership> PartyMemberships { get; set; } = new List<PoliticalPartyMembership>(); 
    public ICollection<CommitteeMembership> CommitteeMemberships { get; set; } = new List<CommitteeMembership>();

    // One-to-many 
    public List<Stock> Stocks { get; set; } = new(); 
    public List<Asset> Assets { get; set; } = new(); 
    public List<Gift> Gifts { get; set; } = new();


}