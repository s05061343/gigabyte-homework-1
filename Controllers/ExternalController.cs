using gigabyte_homework.Models.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace gigabyte_homework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ExternalController(
            ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("[action]/{productId}")]
        public async Task<IActionResult> Tags(int productId)
        {
            Random random = new Random();
            var num = random.Next(3, 5);

            var news = await _context.Tags
                .Where(x => x.ProductId == productId)
                .Take(num)
                .ToListAsync();

            return Ok(news);
        }
    }
}
