using Microsoft.AspNetCore.Mvc;
using NLW_Leilao.API.UseCases.Auctions.GetCurrent;

namespace NLW_Leilao.API.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class AuctionController : ControllerBase
{
    [HttpGet]
    public IActionResult GerCurrentResult()
    {
        var useCase = new GetCurrentAuctionUseCase();
        var result = useCase.Execute();

        return Ok(result);
    }
}