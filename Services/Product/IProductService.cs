using gigabyte_homework.Models.Application;

namespace gigabyte_homework.Services.Product
{
    public interface IProductService
    {
        Task<Models.Application.Product?> GetProductDetailAsync(int productId);
    }
}
