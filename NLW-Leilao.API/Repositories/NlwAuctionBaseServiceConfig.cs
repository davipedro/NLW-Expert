using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace NLW_Leilao.API.Repositories;

public abstract class NlwAuctionBaseServiceConfig : DbContext
{
    protected string ConnectionString;

    protected NlwAuctionBaseServiceConfig()
    {
        ConnectionString = Environment.GetEnvironmentVariable("EF_NLW-AUCTION_CONNECTION_STRING");
    }

    protected NlwAuctionBaseServiceConfig(DbContextOptions<AuctionDbContext> options)
    {
    }
}
