using Microsoft.AspNetCore.Mvc;

namespace Udemy.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(new[] { new { Name = "Bilgisayar", Price = 1500 },
            new{Name="Telefon",Price=1000} });
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            return Ok(new[] { new { Name = "Bilgisayar", Price = 1500 } });
        }
    }
}
