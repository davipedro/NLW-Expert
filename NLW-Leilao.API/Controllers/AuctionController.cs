using Microsoft.AspNetCore.Mvc;
using NLW_Leilao.API.Entities;
using NLW_Leilao.API.Services;

namespace NLW_Leilao.API.Controllers;

public class AuctionController : NlwAuctionBaseController
{
    private readonly AuctionService Service;

    public AuctionController()
    {
        Service = new AuctionService();
    }

    [HttpGet]
    [ProducesResponseType(typeof(Auction) , StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GerCurrentResult()
    {
        var result = Service.GetFirstAuction();

        if (result is null)
            return NoContent();

        return Ok(result);
    }
}