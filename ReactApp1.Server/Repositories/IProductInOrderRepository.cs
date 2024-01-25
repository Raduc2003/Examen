using ReactApp1.Server.Entities;

namespace ReactApp1.Server.Repositories
{
    public interface IProductInOrderRepository
    {
         Task<List<ProductInOrder>> GetProductInOrdersAsync();
        Task<ProductInOrder> AddProductInOrderAsync(ProductInOrder pinorder);
    }
}
