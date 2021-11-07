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
    public class InvoiceController : ControllerBase
    {
        [HttpGet()]
        public List<Invoice> GetAllInvoices()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Invoices.ToList();
            };
        }

        [HttpGet("orderId")]
        public List<Invoice> SearchByOrderId(int orderId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                List<Invoice> result = context.Invoices.Where(e => e.OrderId == orderId).ToList();
                return result;
            }
        }

        [HttpGet("region")]
        public List<Invoice> SearchByRegion(string region)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                List<Invoice> result = context.Invoices.ToList().Where(r => r.Region.ToLower() == region.ToLower()).ToList();
                return result;
            }
        }
    }
}
