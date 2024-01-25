using Microsoft.EntityFrameworkCore;
using ReactApp1.Server.Contexts;
using ReactApp1.Server.Entities;

namespace ReactApp1.Server.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationContext _context;
        public OrderRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<List<Order>> GetOrdersAsync()
        {
            var orders = await _context.Orders.ToListAsync();
            return orders;

        }
        public async Task<Order> AddOrderAsync(Order order)
        {
            _context.Orders.Add(order);
            return order;

        }
    }
       
}
