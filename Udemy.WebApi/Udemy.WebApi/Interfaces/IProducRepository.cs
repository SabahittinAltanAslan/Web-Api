using Udemy.WebApi.Data;

namespace Udemy.WebApi.Interfaces
{
    public interface IProducRepository
    {
        public Task<List<Product>> GetAllAsync();
        public Task<Product> GetByIdAsync(int id);
    }
}
