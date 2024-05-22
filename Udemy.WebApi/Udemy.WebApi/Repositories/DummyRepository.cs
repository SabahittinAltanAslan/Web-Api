using Udemy.WebApi.Interfaces;

namespace Udemy.WebApi.Repositories
{
    public class DummyRepository : IDummyRepository
    {
        public string GetName()
        {
            return "Altan";
        }
    }
}
