using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEf
{
    public class OrderService
    {
        public static List<Order> GetAllOrders()
        {
            using (var db = new OrderContext())
            {
                return AllOrders(db).ToList();
            }
        }
        private static IQueryable<Order> AllOrders(OrderContext db)
        {
            return db.Orders.Include("OrderItem");
        }
        public static void AddOrderItem(Order order, OrderItem newOrderItem)
        {
            using (var context = new OrderContext())
            {
                newOrderItem.OrderId = order.id;
                context.OrderItems.Add(newOrderItem);
                context.SaveChanges();
            }
        }

        public static void addOrder(Order newOrder)
        {
            using (var context = new OrderContext())
            {
                context.Orders.Add(newOrder);
                context.SaveChanges();
            }
        }
        public static bool DeleteOrder(int ID)
        {
            using (var context = new OrderContext())
            {
                var op = context.Orders.Include("OrderItems").SingleOrDefault(o => o.id == ID);
                if (op != null)
                {
                    context.Orders.Remove(op);
                    return true;
                }
                return false;
            }
        }

    }
}
