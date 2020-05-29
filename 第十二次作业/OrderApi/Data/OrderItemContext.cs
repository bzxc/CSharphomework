using Microsoft.EntityFrameworkCore;

namespace OrderApi.Models
{
    public class OrderItemContext : DbContext
    {
        public OrderItemContext(DbContextOptions<OrderContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}