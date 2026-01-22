namespace FollowTheMoney.Models;

using FollowTheMoney.Models;


public class OrganisationPoliticalParty
{
    public Guid OrganisationId { get; set; }
    public Organisation Organisation { get; set; }

    public Guid PoliticalPartyId { get; set; }
    public PoliticalParty PoliticalParty { get; set; }
}
