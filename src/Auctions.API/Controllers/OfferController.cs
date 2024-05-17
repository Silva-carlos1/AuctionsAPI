using Auctions.API.Communication.Requests;
using Auctions.API.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auctions.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : AuctionsBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer([FromRoute]int itemId, [FromBody] RequestCreateOfferjson request)
    {
        return Created();
    }
}
