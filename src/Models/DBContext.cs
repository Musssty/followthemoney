namespace FollowTheMoney.Models;
using Microsoft.EntityFrameworkCore;

public class DBContext : DbContext
{   
    public DbSet<Organisation> Organisations { get; set; }
    public DbSet<Asset> Assets { get; set; }
    public DbSet<Donation> Donations { get; set; }
    public DbSet<PoliticalParty> PoliticalParties { get; set; }
    public DbSet<Politician> Politicians { get; set; }
    public DbSet<Stock> Stocks { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=database.db");
}