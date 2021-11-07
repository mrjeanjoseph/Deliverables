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
        public List<Supplier> GetAllSuppliers() //Listed a list of suppliers
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Suppliers.ToList();
            };
        }

        [HttpGet("companyname")]
        public List<Supplier> SearchByCompanyName(string companyName) //Found Company name
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                List<Supplier> result = context.Suppliers.Where(e => e.CompanyName.ToLower() == companyName.ToLower()).ToList();
                return result;
            }
        }

        [HttpGet("Country")]
        public List<Supplier> SearchByCountry(string country) //Listed Company name by Country
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                List<Supplier> result = context.Suppliers.Where(bd => bd.Country.ToLower() == country.ToLower()).ToList();
                return result;
            }
        }

        [HttpPost("AddSupplier")]
        public Supplier AddSupplierInfo(string companyName, string contactName, string contactTitle, string address, string city, string region, string postal, string country, string phone, string fax, string homepage) //Successfully added a new company using the 
        {
            Supplier newSupplier = new Supplier();
            newSupplier.CompanyName = companyName;
            newSupplier.ContactName = contactName;
            newSupplier.ContactTitle = contactTitle;
            newSupplier.Address = address;
            newSupplier.City = city;
            newSupplier.Region = region;
            newSupplier.PostalCode = postal;
            newSupplier.Country = country;
            newSupplier.Phone = phone;
            newSupplier.Fax = fax;
            newSupplier.HomePage = homepage;

            using (NorthwindContext context = new NorthwindContext())
            {
                context.Suppliers.Add(newSupplier);
                context.SaveChanges();
            };

            return newSupplier;
        }
    }
}
