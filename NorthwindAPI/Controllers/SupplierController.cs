using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        [HttpGet()]
        public List<Supplier> GetAllSuppliers() //Because we are getting all employees, no need for parameters
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Suppliers.ToList();
            };
        }

        [HttpGet("CompanyName")]
        public List<Supplier> SearchByCompanyName(string companyName)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                List<Supplier> result = context.Suppliers.Where(e => e.CompanyName.ToLower() == companyName.ToLower()).ToList();
                return result;
            }
        }

        [HttpGet("Country")]
        public List<Supplier> SearchByCountry(string country)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                List<Supplier> result = context.Suppliers.Where(bd => bd.Country.ToLower() == country.ToLower()).ToList();
                return result;
            }
        }
    }
}
