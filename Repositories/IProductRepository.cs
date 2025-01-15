using ProductAPI.Models;

namespace ProductAPI.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync(int pageNumber, int pageSize);
        Task<Product> GetProductByIdAsync(int id);
        Task UpdateProductDescriptionAsync(int id, string description);
    }
}
