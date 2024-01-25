namespace ReactApp1.Server.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Description { get; set; }

        public List<ProductInOrder> ProductInOrder { get; set; }
    }
}
