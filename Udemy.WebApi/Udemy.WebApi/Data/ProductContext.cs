using Microsoft.EntityFrameworkCore;

namespace Udemy.WebApi.Data
{
    public class ProductContext :DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) 
        { 
        }

        public DbSet<Product> Products { get; set; }
    }
}
