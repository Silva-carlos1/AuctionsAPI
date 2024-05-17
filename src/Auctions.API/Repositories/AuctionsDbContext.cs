using Auctions.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Auctions.API.Repositories;

public class AuctionsDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\duduo\\OneDrive\\Documentos\\C#\\auction.db");
    }
}
