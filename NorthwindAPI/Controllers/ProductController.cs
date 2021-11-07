using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet()]
        public List<Product> GetAllProducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            };
        }

        [HttpGet("productname")]
        public List<Product> SearchByProductName(string productName)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                List<Product> result = context.Products.Where(p => p.ProductName.ToLower() == productName.ToLower()).ToList();
                return result;
            };
        }

        [HttpPost("deleteproduct")]
        public Product DeleteProductByName(string deleteProduct)
        {

            using (NorthwindContext context = new NorthwindContext())
            {
                Product result = context.Products.ToList().Find(p => p.ProductName.ToLower() == deleteProduct.ToLower());
                context.Remove(result);
                context.SaveChanges();
                return result;
            };

            //using (NorthwindContext context = new NorthwindContext()) // Almost worked
            //{
            //    Product toBeDeleted = new Product { ProductName = deleteProduct };
            //    context.Remove(toBeDeleted);
            //    context.SaveChanges();
            //    return toBeDeleted;
            //};


            //NorthwindContext context = new NorthwindContext(); // Almost worked
            //Product toBeDeleted = new Product { ProductName = deleteProduct };
            //context.Entry(toBeDeleted).State = EntityState.Deleted;
            //context.SaveChanges();
            //return toBeDeleted;
        }
    }
}
