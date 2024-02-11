using NLW_Leilao.API.Entities;
using NLW_Leilao.API.Repositories;

namespace NLW_Leilao.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction Execute()
    {
        var repository = new AuctionDbContext();

        var firstAuction = repository.auctions.FirstOrDefault();

        if (firstAuction == null) return new Auction();

        return firstAuction;
    }
}