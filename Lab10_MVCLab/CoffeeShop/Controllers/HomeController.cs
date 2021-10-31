using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Summary()
        {
            List<CustomerModel> customer = new List<CustomerModel>();
            using (var context = new StoreContext())
            {
                customer = context.Customer.ToList();
            }
            return View(customer);
        }

        public IActionResult SaveCustomers(CustomerModel info)
        {
            using (var context = new StoreContext())
            {
                context.Customer.Add(info);
                context.SaveChanges();
            }
            return Redirect("Summary");
        }

        //public IActionResult Summary(CustomerModel info) // this one works
        //{
        //    List<CustomerModel> customer = null;
        //    using (var context = new StoreContext())
        //    {
        //        context.Customer.Add(info);
        //        context.SaveChanges();
        //        customer = context.Customer.ToList();
        //    }
        //    return View(customer);
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
