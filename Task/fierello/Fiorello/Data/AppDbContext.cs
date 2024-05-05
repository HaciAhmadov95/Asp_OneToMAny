using Fiorello.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiorello.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
    {

    }

    public DbSet<Surprize> Surprizes { get; set; }
    public DbSet<SurprizeList> SurprizeLists { get; set; }
    public DbSet<Expert> Experts { get; set; }
    public DbSet<Position> Positions { get; set; }

}
