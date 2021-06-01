using MessageBoard.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoard.Controllers
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

        
        public IActionResult messageboard()
        {
            List<Message> listOfMessages = new List<Message>();
            using (MessageBoardDBContext context = new MessageBoardDBContext())
            {
                listOfMessages =  (context.Messages.ToList());
            };

            return View(listOfMessages);
        }

        [HttpPost]
        public IActionResult messageboard(string message)
        {
            Message message1 = new Message();
            using (MessageBoardDBContext context = new MessageBoardDBContext())
            {
                message1.UserId = User.Identity.Name;
                message1.EmailAddress = User.Identity.Name;
                message1.PostedTime = DateTime.Now;
                message1.Updated = false;
                message1.Message1 = message;
                context.Messages.Add(message1);
                context.SaveChanges();
            };
            return Redirect("messageboard");
            //return View(message1); // 
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
