using ProductAPI.Models;
using ProductAPI.Repositories;

namespace ProductAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync(int pageNumber, int pageSize)
        {
            return await _repository.GetAllProductsAsync(pageNumber, pageSize);
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _repository.GetProductByIdAsync(id);
        }

        public async Task UpdateProductDescriptionAsync(int id, string description)
        {
            await _repository.UpdateProductDescriptionAsync(id, description);
        }
    }
}
