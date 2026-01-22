namespace FollowTheMoney.Models;

public class PoliticianOrganisation
{
    public Guid PoliticianId { get; set; }
    public Politician Politician { get; set; }
    
    public Guid OrganisationId { get; set; }
    public Organisation Organisation { get; set; }
}