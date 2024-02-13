using Microsoft.EntityFrameworkCore;
using NLW_Leilao.API.Entities;

namespace NLW_Leilao.API.Repositories;

public class AuctionDbContext : NlwAuctionBaseServiceConfig
{
    private readonly string ConnectionString;

    public AuctionDbContext()
    {
        this.ConnectionString = base.ConnectionString;
    }

    public AuctionDbContext(DbContextOptions<AuctionDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(ConnectionString);
    }

    public DbSet<Auction> auctions { get; set;}
}
