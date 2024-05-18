using Auctions.API.Contracts;
using Auctions.API.Entities;
using Auctions.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Auctions.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    private readonly IAuctionRepository _repository;
    public GetCurrentAuctionUseCase(IAuctionRepository repository) => _repository = repository;
    public Auction? Execute()
    {
        return _repository.GetCurrent();
    }
}
