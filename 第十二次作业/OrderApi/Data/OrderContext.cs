using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderApi.Models;

    public class OrderContext : DbContext
    {
        public OrderContext (DbContextOptions<OrderContext> options)
            : base(options)
        {
        }

        public DbSet<OrderApi.Models.Order> Order { get; set; }

        public DbSet<OrderApi.Models.OrderItem> OrderItem { get; set; }

    }
