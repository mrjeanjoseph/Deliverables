using DeckOfCards.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DeckOfCards.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private GetDeckCardDAL _getDeck = new GetDeckCardDAL();

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

        public IActionResult DrawCards()
        {
            ShuffleCardModel cardDeckModel = _getDeck.ConvertJsonNewDeck();
           //DrawCardModel drawcard = _getDeck.ConvertJsonDrawCard(cardDeckModel.deck_id, "5");
            return View(cardDeckModel);


        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
