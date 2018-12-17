using netCore.Models;
using Microsoft.EntityFrameworkCore;

namespace netCore.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext()
        {
        }

        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Feature> Features { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
            .HasOne<Feature>(s => s.Features)
            .WithOne(ad => ad.Products)
            .HasForeignKey<Feature>(ad => ad.ProductForeignKey);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Products;Trusted_Connection=True;");
        }
    }
}
