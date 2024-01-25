using Microsoft.EntityFrameworkCore;
using ReactApp1.Server.Contexts;
using ReactApp1.Server.Entities;

namespace ReactApp1.Server.Repositories
{
    public class ProductInOrderRepository : IProductInOrderRepository
    {
        private readonly ApplicationContext _context;
        public ProductInOrderRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<List<ProductInOrder>> GetProductInOrdersAsync()
        {
            var productsInOrder = await _context.ProductInOrder.ToListAsync();
            return productsInOrder;

        }
        public async Task<ProductInOrder> AddProductInOrderAsync(ProductInOrder pinorder)
        {
            _context.ProductInOrder.Add(pinorder);
            return pinorder;

        }
    }
       
}
