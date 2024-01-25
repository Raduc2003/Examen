using ReactApp1.Server.Entities;

namespace ReactApp1.Server.Repositories
{
    public interface IProductRepository
    {
         Task<List<Product>> GetProductsAsync();
        Task<Product> AddProductAsync(Product product);
    }
}
