using FollowTheMoney.Models;

namespace FollowTheMoney.Models.JoinEntities;

public class OrganisationPoliticalParty
{
    public Guid OrganisationId { get; set; }
    public Organisation Organisation { get; set; }

    public Guid PoliticalPartyId { get; set; }
    public PoliticalParty PoliticalParty { get; set; }
}
