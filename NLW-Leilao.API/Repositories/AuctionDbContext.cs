using Microsoft.EntityFrameworkCore;
using NLW_Leilao.API.Entities;

namespace NLW_Leilao.API.Repositories;

public class AuctionDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DbSet<Auction> auctions { get; set; }

    public AuctionDbContext() { }

    public AuctionDbContext(IConfiguration configuration)
    {
        this.Configuration = configuration;
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(@"Host=localhost;Username=postgres;Password=D02dps$;Database=nlw_auction");
    }
}
