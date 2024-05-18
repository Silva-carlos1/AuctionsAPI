using Auctions.API.Communication.Requests;
using Auctions.API.Filters;
using Auctions.API.UseCases.Offers.CreateOffer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auctions.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : AuctionsBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer([FromRoute]int itemId, [FromBody] RequestCreateOfferjson request, [FromServices] CreateOfferUseCase useCase)
    {
        var id = useCase.Execute(itemId, request);

        return Created(string.Empty, id);
    }
}
