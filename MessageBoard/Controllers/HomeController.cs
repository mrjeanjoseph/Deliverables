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




        [Authorize]
        public IActionResult messageboard()
        {
            List<Message> listOfMessages = new List<Message>();
            using (MessageBoardDBContext context = new MessageBoardDBContext())
            {
                listOfMessages = (context.Messages.ToList());
            };

            return View(listOfMessages);
        }

        [Authorize]
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

        [Authorize]
        [HttpPost]
        public IActionResult editmessage(int userId, string message) // This is for the edit page
        {
            Message message1 = new Message();
            using (MessageBoardDBContext context = new MessageBoardDBContext())
            {
                message1 = context.Messages.ToList().Find(m => m.Id == userId);
                message1.Message1 = message;
                message1.Updated = true;
                context.SaveChanges();
            };
            return Redirect("messageboard");
            //return View(message1); // 
        }

        //[HttpPost] // 
        public IActionResult UpdateMessage(int userId) // This is for the edit page
        {
            using (MessageBoardDBContext context = new MessageBoardDBContext())
            {
                Message message = new Message();
                message = context.Messages.ToList().Find(m => m.Id == userId);

                return View(message);
            };
        }



        [Authorize]
        [HttpPost]
        public IActionResult DeleteMessages(int userId, string message) // This will handle deleting a message when cliced on.
        {
            Message message1 = new Message();
            using (MessageBoardDBContext context = new MessageBoardDBContext())
            {
                message1 = context.Messages.ToList().Find(m => m.Id == userId);
                message1.Message1 = message;
                context.Messages.Remove(message1);
                context.SaveChanges();
            };

            return Redirect("messageboard");
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
