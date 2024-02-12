using Microsoft.AspNetCore.Mvc;
using NLW_Leilao.API.Entities;
using NLW_Leilao.API.UseCases.Auctions.GetCurrent;

namespace NLW_Leilao.API.Controllers;

public class AuctionController : NlwAuctionBaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction) , StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GerCurrentResult()
    {
        var useCase = new GetCurrentAuctionUseCase();
        var result = useCase.Execute();

        if (result is null)
            return NoContent();

        return Ok(result);
    }
}