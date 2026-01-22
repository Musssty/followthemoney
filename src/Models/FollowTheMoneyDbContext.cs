using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using FollowTheMoney.Models;
=======
using FollowTheMoney.Models.JoinEntities;
>>>>>>> 1566e645d8648ed45d622c6a5bcb52d50dbbf2d5

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
    public DbSet<Organisation> Organisations { get; set; }
    public DbSet<Donation> Donations { get; set; }
    public DbSet<Stock> Stocks { get; set; }
    public DbSet<Asset> Assets { get; set; }
    public DbSet<Gift> Gifts { get; set; }

    // Join Entities
    public DbSet<PoliticianOrganisation> PoliticianOrganisations { get; set; }
    public DbSet<OrganisationPoliticalParty> OrganisationPoliticalParties { get; set; }
    public DbSet<PoliticianDonation> PoliticianDonations { get; set; }
<<<<<<< HEAD
    
=======

>>>>>>> 1566e645d8648ed45d622c6a5bcb52d50dbbf2d5
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Politician ↔ Organisation
        modelBuilder.Entity<PoliticianOrganisation>()
            .HasKey(po => new { po.PoliticianId, po.OrganisationId });

        modelBuilder.Entity<PoliticianOrganisation>()
            .HasOne(po => po.Politician)
            .WithMany(p => p.PoliticianOrganisations)
            .HasForeignKey(po => po.PoliticianId);

        modelBuilder.Entity<PoliticianOrganisation>()
            .HasOne(po => po.Organisation)
            .WithMany(o => o.PoliticianOrganisations)
            .HasForeignKey(po => po.OrganisationId);

        // Organisation ↔ PoliticalParty
        modelBuilder.Entity<OrganisationPoliticalParty>()
            .HasKey(op => new { op.OrganisationId, op.PoliticalPartyId });

        modelBuilder.Entity<OrganisationPoliticalParty>()
            .HasOne(op => op.Organisation)
            .WithMany(o => o.OrganisationPoliticalParties)
            .HasForeignKey(op => op.OrganisationId);

        modelBuilder.Entity<OrganisationPoliticalParty>()
            .HasOne(op => op.PoliticalParty)
<<<<<<< HEAD
            .WithMany(pp => pp.OrganisationPoliticalParties)
=======
            .WithMany(pp => pp.Donations)
>>>>>>> 1566e645d8648ed45d622c6a5bcb52d50dbbf2d5
            .HasForeignKey(op => op.PoliticalPartyId);

        // Politician ↔ Donation
        modelBuilder.Entity<PoliticianDonation>()
            .HasKey(pd => new { pd.PoliticianId, pd.DonationId });

        modelBuilder.Entity<PoliticianDonation>()
            .HasOne(pd => pd.Politician)
            .WithMany(p => p.PoliticianDonations)
            .HasForeignKey(pd => pd.PoliticianId);

        modelBuilder.Entity<PoliticianDonation>()
            .HasOne(pd => pd.Donation)
            .WithMany(d => d.PoliticianDonations)
            .HasForeignKey(pd => pd.DonationId);

        // Politician → PoliticalParty
        modelBuilder.Entity<Politician>()
            .HasOne(p => p.PoliticalParty)
            .WithMany(pp => pp.Politicians)
            .HasForeignKey(p => p.PoliticalPartyId);

        // Donation → Organisation & Party
        modelBuilder.Entity<Donation>()
            .HasOne(d => d.Organisation)
            .WithMany(o => o.Donations)
            .HasForeignKey(d => d.OrganisationId);

        modelBuilder.Entity<Donation>()
            .HasOne(d => d.PoliticalParty)
            .WithMany(pp => pp.Donations)
            .HasForeignKey(d => d.PoliticalPartyId);

        // Stock → Politician
        modelBuilder.Entity<Stock>()
            .HasOne(s => s.Politician)
            .WithMany(p => p.Stocks)
            .HasForeignKey(s => s.PoliticianId);

        // Asset → Politician
        modelBuilder.Entity<Asset>()
            .HasOne(a => a.Politician)
            .WithMany(p => p.Assets)
            .HasForeignKey(a => a.PoliticianId);

        // Gift → Politician
        modelBuilder.Entity<Gift>()
            .HasOne(g => g.Politician)
            .WithMany(p => p.Gifts)
            .HasForeignKey(g => g.PoliticianId);
    }
}
