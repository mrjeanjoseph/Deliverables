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
            DisplayMenu();
            MovieSelection();
            Console.ReadLine();
        }

        static void MovieSelection()
        {
            Console.WriteLine("Choose an option: Search by 'Title' or 'Genre'");
            string userChoose = Console.ReadLine();
            Console.WriteLine("Searching for a movie by title: ");
            Console.WriteLine("Enter the name of the movie you like to see");
            if (userChoose == "title")
            {
                string userInput = Console.ReadLine();
                List<string> list = SearchByTitle(userInput);
                foreach (string item in list)
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }

        }

        static void DisplayMenu()
        {
            using (var context = new MovieDBContext())
            {
                foreach (var movieList in context.Movies)
                {
                    Console.WriteLine($"{ movieList.Title }\t{ movieList.Genre }\t{ movieList.Runtime}");
                }
            };
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

        static List<string> SearchByTitle(string userInput)
        {

            using (var context = new MovieDBContext())
            {

                var movie = context.Movies.Where(m => m.Title == userInput).ToList();

                List<string> result = new List<string>();
                foreach (var movies in movie)
                {
                    result.Add($"{ movies.Title }\t{ movies.Genre }");
                }
                return result;
            };
        }

        static void PopulateMovies()
        {
            using (var context = new MovieDBContext())
            {
                //Creating the constructor enabled the option to create multiple new movies at once.
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
