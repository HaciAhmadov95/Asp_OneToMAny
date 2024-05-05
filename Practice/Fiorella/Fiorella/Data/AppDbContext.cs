using Fiorella.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiorella.Data
{
    public class AppDbContext : DbContext
    {
        internal object SlidersInfos;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SlidersInfo { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

    }
}
