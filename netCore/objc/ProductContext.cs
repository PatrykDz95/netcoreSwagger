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
            .HasOne(s => s.Feature)
            .WithOne(ad => ad.Product);
            //.HasForeignKey<Feature>(b => b.ProductForeignKey);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Products;Trusted_Connection=True;");
        }
    }
}
