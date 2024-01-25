namespace ReactApp1.Server.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

    }
}
