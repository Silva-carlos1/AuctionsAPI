﻿using Auctions.API.Contracts;
using Auctions.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Auctions.API.Repositories.DataAccess;

public class AuctionRepository : IAuctionRepository
{
  private readonly AuctionsDbContext _dbContext;
  public AuctionRepository(AuctionsDbContext dbContext) => _dbContext = dbContext;

  public Auction? GetCurrent()
  {
    var today = new DateTime(2024, 01, 28);

    return _dbContext
      .Auctions
      .Include(auction => auction.Items) 
      .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
  }

}
