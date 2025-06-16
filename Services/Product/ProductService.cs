using gigabyte_homework.Models.Application;
using Microsoft.EntityFrameworkCore;

namespace gigabyte_homework.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ProductService(
            ApplicationDbContext context, 
            HttpClient httpClient, 
            IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpClient = httpClient;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<Models.Application.Product?> GetProductDetailAsync(int productId)
        {
            var product = await _context.Products
                .Include(p => p.Images.Take(3))
                .Include(p => p.Specifications.Take(4))
                .Include(p => p.RelatedNews)
                .FirstOrDefaultAsync(p => p.Id == productId);

            if (product == null) return null;

            // 模擬呼叫外部 API 獲得相關新聞 (3~5 則)
            // 取得自己的 Host
            var request = _httpContextAccessor.HttpContext.Request;
            var baseUrl = $"{request.Scheme}://{request.Host}";
            var externalTags = await _httpClient
                .GetFromJsonAsync<List<Tag>>($"{baseUrl}/api/external/tags/{productId}");
            if (externalTags != null)
            {
                product.Tags = externalTags.Take(5).ToList(); // 取最多5筆
            }

            return product;
        }
    }
}
