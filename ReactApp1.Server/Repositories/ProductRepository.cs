using Microsoft.EntityFrameworkCore;
using ReactApp1.Server.Contexts;
using ReactApp1.Server.Entities;

namespace ReactApp1.Server.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationContext _context;
        public ProductRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> GetProductsAsync()
        {
            var products = await _context.Products.ToListAsync();
            return products;

        }
        public async Task<Product> AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            return product;

        }
    }
       
}
