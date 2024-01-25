namespace ReactApp1.Server.Entities
{
    public class ProductInOrder
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        public Product Product { get; set; }

        public Order Order { get; set; }

    }
}
