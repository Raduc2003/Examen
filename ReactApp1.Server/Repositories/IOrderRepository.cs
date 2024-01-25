using ReactApp1.Server.Entities;

namespace ReactApp1.Server.Repositories
{
    public interface IOrderRepository
    {
         Task<List<Order>> GetOrdersAsync();
        Task<Order> AddOrderAsync(Order order);
    }
}
