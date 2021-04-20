using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ListOfMovies viewAList = new ListOfMovies("Find Your Movies!");
            Console.WriteLine(viewAList.Greeting());

            bool reRunProgram = true;
            while (reRunProgram)
            {
                viewAList.DisplayAllMovies();
                string userSearch = viewAList.GetUserInput("What category of movies are you interested in?: ");
                viewAList.GetMoviesByCategory(userSearch);

                Console.WriteLine("Would you like to search again: (y/n)");
                while (true)
                {
                    string tryAgain = Console.ReadLine();
                    if (tryAgain == "y")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (tryAgain == "n")
                    {
                        reRunProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please choose y/n");
                    }
                }
            }
            Console.WriteLine("Thank you for using our application");
            Console.ReadLine();
        }
    }
}
