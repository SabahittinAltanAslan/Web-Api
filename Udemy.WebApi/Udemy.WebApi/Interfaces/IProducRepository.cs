using Udemy.WebApi.Data;

namespace Udemy.WebApi.Interfaces
{
    public interface IProducRepository
    {
        public Task<List<Product>> GetAllAsync();
        public Task<Product> GetByIdAsync(int id);
        public Task<Product> CreateAsync(Product product);

        public Task UpdateAsync(Product product);
        public Task RemoveAsync(int id);

    }
}
