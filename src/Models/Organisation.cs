namespace FollowTheMoney.Models;

public class Organisation
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Industry { get; set; }
    public required string Type { get; set; }
    public required string Address { get; set; }
    public required string City { get; set; }
    public required string State { get; set; }
    public required string Postcode { get; set; }
    public string? Website { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

    public List<PoliticianOrganisation> PoliticianOrganisations { get; set; } = new();
    public List<OrganisationPoliticalParty> OrganisationPoliticalParties { get; set; } = new();
    public List<Donation> Donations { get; set; } = new();
}
