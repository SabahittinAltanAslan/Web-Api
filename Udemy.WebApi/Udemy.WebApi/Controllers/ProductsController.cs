using Microsoft.AspNetCore.Mvc;
using Udemy.WebApi.Data;
using Udemy.WebApi.Interfaces;
using Udemy.WebApi.Repositories;

namespace Udemy.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProducRepository _productRepository;
        public ProductsController(IProducRepository producRepository)
        {
            _productRepository = producRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productRepository.GetAllAsync();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result =  await _productRepository.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound(id);
            }
            return Ok(result);
        }
    }
}
