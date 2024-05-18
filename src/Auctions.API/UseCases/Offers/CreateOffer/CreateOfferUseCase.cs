using Auctions.API.Communication.Requests;
using Auctions.API.Entities;
using Auctions.API.Repositories;
using Auctions.API.Services;

namespace Auctions.API.UseCases.Offers.CreateOffer;

public class CreateOfferUseCase
{
    private readonly LoggedUser _loggedUser;
    public CreateOfferUseCase(LoggedUser loggedUser) => _loggedUser = loggedUser; 

    public int Execute(int itemId, RequestCreateOfferjson request)
    {
        var repository = new AuctionsDbContext();

        var user = _loggedUser.User();

        var offer = new Offer
        {
            CreatedOn = DateTime.Now,
            ItemId = itemId,
            Price = request.Price,
            UserId = user.Id,
        };

        repository.Offers.Add(offer);

        repository.SaveChanges();

        return offer.Id;
    }
}
