using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricBoogaloo.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string ItemName { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        public int ProductId { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}
