using Microsoft.AspNetCore.Mvc;

namespace NLW_Leilao.API.Controllers;

public class OfferController : NlwAuctionBaseController
{
    [HttpPost]
    public IActionResult CreateOffer()
    {
        return Created();
    }
}
