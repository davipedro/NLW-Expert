using Microsoft.EntityFrameworkCore;
using NLW_Leilao.API.Entities;
using NLW_Leilao.API.Repositories;

namespace NLW_Leilao.API.Services;

public class AuctionService
{
    private AuctionDbContext Repository;

    public AuctionService()
    {
        this.Repository = new AuctionDbContext();
    }

    public Auction GetFirstAuction()
    {
        var today = DateTime.Now;

        var firstAuction = Repository
            .auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);

        if (firstAuction == null) return new Auction();

        return firstAuction;
    }
}