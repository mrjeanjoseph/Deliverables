using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}
