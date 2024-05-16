using Auctions.API.Entities;
using Auctions.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Auctions.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction? Execute()
    {
        var repository = new AuctionsDbContext();

        var today = DateTime.Now;


        return repository
            .Auctions
            .Include(auction =>  auction.Items)
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }
}
