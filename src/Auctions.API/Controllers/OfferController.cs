using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auctions.API.Controllers;

public class OfferController : AuctionsBaseController
{
    [HttpPost]
    public IActionResult CreateOffer()
    {
        return Created();
    }
}
