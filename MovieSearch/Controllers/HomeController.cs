using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieSearch.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieSearch.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly MovieDAL _movieDAL = new MovieDAL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult MovieSearch()
        {
            //Default method
            return View();
        }

        [HttpPost]
        public IActionResult MovieSearch(string Title = "")
        {
            MovieModel movie = new MovieModel();
            movie = _movieDAL.ConvertMovieData(Title);
            return View(movie);
        }

        public IActionResult MovieNight()
        {

            return View();
        }

        [HttpPost]
        public IActionResult MovieNight(string title1, string title2, string title3)
        {
            List<string> multipleTitles = new List<string>();
            multipleTitles.Add(title1);
            multipleTitles.Add(title2);
            multipleTitles.Add(title3);
            List<MovieModel> movies = _movieDAL.MovieList(multipleTitles);

            return View(movies);
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
