using Microsoft.EntityFrameworkCore;
using ProductAPI.Models;

namespace ProductAPI.Data
{
        public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Product 1", ImgUri = "https://example.com/1.jpg", Price = 999 },
                new Product { Id = 2, Name = "Product 2", ImgUri = "https://example.com/2.jpg", Price = 256 }
            );
        }
    }
}
