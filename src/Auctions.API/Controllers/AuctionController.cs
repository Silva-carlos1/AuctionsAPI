using Microsoft.AspNetCore.Mvc;
using Auctions.API.UseCases.Auctions.GetCurrent;

namespace Auctions.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuctionController : ControllerBase
{
    [HttpGet]
    public IActionResult CurrentAuction()
    {
        var useCase = new GetCurrentAuctionUseCase();
        var result = useCase.Execute();

        return Ok(result);
    }
}
