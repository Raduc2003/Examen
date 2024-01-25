using Microsoft.EntityFrameworkCore;
using ReactApp1.Server.Entities;

namespace ReactApp1.Server.Contexts
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductInOrder> ProductInOrder { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductInOrder>()
              .HasKey(pio => new { pio.ProductId, pio.OrderId });

            modelBuilder.Entity<ProductInOrder>()
                .HasOne(pio => pio.Product)
                .WithMany(p => p.ProductInOrder)
                .HasForeignKey(pio => pio.ProductId);

            modelBuilder.Entity<ProductInOrder>()
                .HasOne(pio => pio.Order)
                .WithMany(o => o.ProductInOrder)
                .HasForeignKey(pio => pio.OrderId);
        }

    }
}
