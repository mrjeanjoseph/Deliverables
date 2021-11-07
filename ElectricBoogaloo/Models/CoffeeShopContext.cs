using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricBoogaloo.Models
{
    public class CoffeeShopContext : DbContext
    {
        public DbSet<CustomerModel> Customer { get; set; }
        public DbSet<ProductModel> Product { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            @"Server=.\SQLEXPRESS;Database=ElecBoogaloo;Integrated Security=SSPI;");

        }
    }
}
