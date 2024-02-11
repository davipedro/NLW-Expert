using Microsoft.EntityFrameworkCore;
using NLW_Leilao.API.Entities;
using NLW_Leilao.API.Repositories;

namespace NLW_Leilao.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction Execute()
    {
        var repository = new AuctionDbContext();

        var today = DateTime.Now;

        var firstAuction = repository
            .auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);

        if (firstAuction == null) return new Auction();

        return firstAuction;
    }
}