using Microsoft.EntityFrameworkCore;
using Udemy.WebApi.Data;
using Udemy.WebApi.Interfaces;

namespace Udemy.WebApi.Repositories
{
    public class ProductRepository : IProducRepository
    {
        private readonly ProductContext _context;

        public ProductRepository(ProductContext context)
        {
                _context = context;
        }
        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}
