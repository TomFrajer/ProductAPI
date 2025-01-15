using ProductAPI.Models;

namespace ProductAPI.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync(int pageNumber, int pageSize);
        Task<Product> GetProductByIdAsync(int id);
        Task UpdateProductDescriptionAsync(int id, string description);
    }
}
