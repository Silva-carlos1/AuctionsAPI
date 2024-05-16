using Microsoft.AspNetCore.Mvc;
using Auctions.API.UseCases.Auctions.GetCurrent;
using Auctions.API.Entities;
using System.Runtime.Serialization;

namespace Auctions.API.Controllers;

public class AuctionController : AuctionsBaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult CurrentAuction()
    {
        var useCase = new GetCurrentAuctionUseCase();

        var result = useCase.Execute();

        if (result is null)
            return NoContent();

        return Ok(result);
    }

    
}
