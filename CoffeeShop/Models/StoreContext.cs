using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class StoreContext : DbContext
    {
            public DbSet<CustomerModel> Customer { get; set; }
            public DbSet<ItemModel> Items { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(
                @"Server=.\SQLEXPRESS;Database=CoffeeShop;Integrated Security=SSPI;");
        }
        
    }
}
