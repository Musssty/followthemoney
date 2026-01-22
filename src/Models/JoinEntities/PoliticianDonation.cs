using System;
using FollowTheMoney.Models;   // REQUIRED

namespace FollowTheMoney.Models.JoinEntities;

public class PoliticianDonation
{
    public Guid PoliticianId { get; set; }
    public Politician Politician { get; set; }

    public Guid DonationId { get; set; }
    public Donation Donation { get; set; }
}
