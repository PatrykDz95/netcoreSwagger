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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }
    }   
}
