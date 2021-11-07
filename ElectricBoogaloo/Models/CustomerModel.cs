using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricBoogaloo.Models
{
    public class CustomerModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(75)]
        public string EmailAddress { get; set; }

        [StringLength(50)]
        public string Password { get; set; }
    }
}
