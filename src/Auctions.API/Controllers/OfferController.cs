using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auctions.API.Controllers;

public class OfferController : AuctionsBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer([FromRoute]int itemId)
    {
        return Created();
    }
}
