using Auctions.API.Entities;
using Auctions.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Auctions.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction Execute()
    {
        var repository = new AuctionsDbContext();

        return repository
            .Auctions
            .First();
    }
}
