using Microsoft.EntityFrameworkCore;
using NLW_Leilao.API.Entities;

namespace NLW_Leilao.API.Repositories;

public class AuctionDbContext : DbContext
{
    private string connectionString = Environment.GetEnvironmentVariable("EF_NLW-AUCTION_CONNECTION_STRING");

    protected readonly IConfiguration Configuration;

    public DbSet<Auction> auctions { get; set; }

    public AuctionDbContext() { }

    public AuctionDbContext(IConfiguration configuration)
    {
        this.Configuration = configuration;
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(connectionString);
    }
}
