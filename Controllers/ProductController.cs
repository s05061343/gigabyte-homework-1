using gigabyte_homework.Services.Product;
using Microsoft.AspNetCore.Mvc;

namespace gigabyte_homework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(
            IProductService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _service.GetProductDetailAsync(id);

            if (product == null) return BadRequest();

            return Ok(product);
        }
    }
}
