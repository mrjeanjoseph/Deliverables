using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //PopulateMovies();
            List<string> list = SearchByTitle();
            foreach (string item in list)
            {
                Console.WriteLine(item); 
            }
            Console.ReadLine();
        }

        static List<string> SearchByGenre()
        {
            Console.WriteLine("Search for a movie by genre: ");
            using (var context = new MovieDBContext())
            {
                string userInput = Console.ReadLine();
                var movie = context.Movies.Where(m => m.Genre == userInput).ToList();

                List<string> result = new List<string>();
                foreach (var movies in movie)
                {
                    result.Add($"{ movies.Title }\t{ movies.Genre }");
                }
                return result;
            };
        }

        static List<string> SearchByTitle()
        {
            Console.WriteLine("Search for a movie by title: ");
            using (var context = new MovieDBContext())
            {
                string userInput = Console.ReadLine();
                var movie = context.Movies.Where(m => m.Title == userInput).ToList();

                List<string> result = new List<string>();
                foreach (var movies in movie)
                {
                    result.Add($"{ movies.Title }\t{ movies.Title }");
                }
                return result;
            };
        }

        static void PopulateMovies()
        {
            using (var context = new MovieDBContext())
            {
                List<Movie> movieList = new List<Movie>()
                {
                    new Movie("Chucky", "Horror", 100.3), 
                    new Movie("Star Wars", "Scifi", 153.15),
                };
                foreach (Movie m in movieList)
                {
                    context.Movies.Add(m);
                    Console.WriteLine($"{m.Title} has been saved!");
                    context.SaveChanges();
                }
            };
        }
    }
}
