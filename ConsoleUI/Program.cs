using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ListOfMovies viewAList = new ListOfMovies("Find Your Movies!");

            Console.WriteLine(viewAList.Greeting());
            viewAList.DisplayAllMovies();
            string userSearch = viewAList.GetUserInput("What category of movies are you interested in?: ");

            Console.WriteLine($"Here's a list of movies from the { userSearch } category:");
            viewAList.GetMoviesByCategory(userSearch);

            Console.ReadLine();
        }
    }
}
