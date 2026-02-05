using Microsoft.EntityFrameworkCore;
using FollowTheMoney.Models;

namespace FollowTheMoney.Models;

public class FollowTheMoneyDbContext : DbContext
{
    public FollowTheMoneyDbContext(DbContextOptions<FollowTheMoneyDbContext> options)
        : base(options)
    {
    }

    // Main Entities
    public DbSet<Politician> Politicians { get; set; }
    public DbSet<PoliticalParty> PoliticalParties { get; set; }
    public DbSet<Electorate> Electorates { get; set; }
    public DbSet<Committee> Committees { get; set; }
    public DbSet<CommitteeMembership> CommitteeMemberships { get; set; }
    public DbSet<PoliticalPartyMembership> PoliticalPartyMemberships { get; set; }

    // Other domain entities
    public DbSet<Organisation> Organisations { get; set; }
    public DbSet<Donation> Donations { get; set; }
    public DbSet<Stock> Stocks { get; set; }
    public DbSet<Asset> Assets { get; set; }
    public DbSet<Gift> Gifts { get; set; }
    public DbSet<GovOrg> GovOrgs { get; set; }
    public DbSet<Donor> Donors { get; set; }

    // Join Entities (if still used)
    //public DbSet<PoliticianOrganisation> PoliticianOrganisations { get; set; }
    public DbSet<OrganisationPoliticalParty> OrganisationPoliticalParties { get; set; }
    public DbSet<PoliticianDonation> PoliticianDonations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

       

        // -----------------------------
        // Many-to-many: Organisation ↔ PoliticalParty
        // -----------------------------
        modelBuilder.Entity<OrganisationPoliticalParty>()
            .HasKey(op => new { op.OrganisationId, op.PoliticalPartyId });

        // -----------------------------
        // Many-to-many: Politician ↔ Donation
        // -----------------------------
        modelBuilder.Entity<PoliticianDonation>()
            .HasKey(pd => new { pd.PoliticianId, pd.DonationId });

        // -----------------------------
        // One-to-many: Donor → Donations
        // -----------------------------
        modelBuilder.Entity<Donor>()
            .HasMany(d => d.Donations)
            .WithOne(don => don.Donor)
            .HasForeignKey(don => don.DonorId);

        // -----------------------------
        // One-to-many: Electorate → Politicians
        // -----------------------------
        modelBuilder.Entity<Electorate>()
            .HasMany(e => e.Politicians)
            .WithOne(p => p.ElectorateRef)
            .HasForeignKey(p => p.ElectorateId)
            .OnDelete(DeleteBehavior.SetNull);

        // -----------------------------
        // Many-to-many (via join): Politician ↔ PoliticalParty
        // -----------------------------
        modelBuilder.Entity<PoliticalPartyMembership>()
            .HasOne(ppm => ppm.Politician)
            .WithMany(p => p.PartyMemberships)
            .HasForeignKey(ppm => ppm.PoliticianId);

        modelBuilder.Entity<PoliticalPartyMembership>()
            .HasOne(ppm => ppm.PoliticalParty)
            .WithMany(pp => pp.Memberships)
            .HasForeignKey(ppm => ppm.PoliticalPartyId);

        // -----------------------------
        // Many-to-many (via join): Politician ↔ Committee
        // -----------------------------
        modelBuilder.Entity<CommitteeMembership>()
            .HasOne(cm => cm.Politician)
            .WithMany(p => p.CommitteeMemberships)
            .HasForeignKey(cm => cm.PoliticianId);

        modelBuilder.Entity<CommitteeMembership>()
            .HasOne(cm => cm.Committee)
            .WithMany(c => c.Memberships)
            .HasForeignKey(cm => cm.CommitteeId);
    }
}
