using Microsoft.AspNetCore.Mvc;
using Auctions.API.UseCases.Auctions.GetCurrent;
using Auctions.API.Entities;

namespace Auctions.API.Controllers;
[Route("[controller]")]
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
