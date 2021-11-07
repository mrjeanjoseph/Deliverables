using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool RunProgramAgain = true;
            while (RunProgramAgain)
            {
                Console.Clear();
                //PopulateMovies();
                WriteAt("WELCOME TO GRANT CHIRPUS MOVIE SELECTION!", 10, 1);
                MovieSelection();

                Console.WriteLine("Would you like to search for another movie");
                string userchoose = Validation.YesNoChoice();
                if (userchoose != "y")
                {
                    break;
                }
            }
        }

        static void MovieSelection()
        {
            while (true)
            {
                WriteAt("You can search by 'Title' or 'Genre'", 13, 2);
                string userChoose = Console.ReadLine().ToLower().Trim();
                if (userChoose == "title")
                {
                    Console.Clear();
                    WriteAt($"Here's a list of movies by { userChoose } ", 10, 1);
                    Console.WriteLine(string.Format("{0,-5}{1,-25}{2,-15}{3, -15}", "ID", "Title", "Genre", "Runtime"));
                    Console.WriteLine(string.Format("{0,-5}{1,-25}{2,-15}{3, -15}", "--", "-----", "-----", "-------"));
                    DisplayMenu(userChoose);

                    Console.WriteLine("what movies would you like to view?");
                    string userInput = Console.ReadLine();
                    List<string> list = SearchByTitle(userInput);
                    foreach (string item in list)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                }
                else if (userChoose == "genre")
                {
                    Console.Clear();
                    WriteAt($"Here's a list of movies by { userChoose }: ", 10, 1);
                    Console.WriteLine(string.Format("{0,-5}{1,-15}{2,-25}{3, -15}", "ID", "Genre", "Title", "Runtime"));
                    Console.WriteLine(string.Format("{0,-5}{1,-15}{2,-25}{3, -15}", "--", "-----", "-----", "-------"));
                    DisplayMenu(userChoose);

                    Console.WriteLine("What genre of movies would you like to search for? ");
                    string userInput = Console.ReadLine();
                    List<string> list = SearchByGenre(userInput);
                    foreach (string item in list)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("that was an invalid input. Try again");
                }
            }
        }

        static void DisplayMenu(string choice)
        {
            using (var context = new MovieDBContext())
            {
                int count = 4;
                foreach (var movieList in context.Movies)
                {
                    count++;
                    if (choice == "title")
                    {
                        string result = string.Format("{0,-5}{1,-25}{2,-15}{3, -15}", movieList.Id, movieList.Title, movieList.Genre, movieList.Runtime);
                        Console.WriteLine(result);
                    }
                    else if (choice == "genre")
                    {
                        string result = string.Format("{0,-5}{1,-15}{2,-25}{3, -15}", movieList.Id, movieList.Genre, movieList.Title, movieList.Runtime);
                        Console.WriteLine(result);
                    }
                }
                WriteAt("", 0, count + 4);
            };
        }

        static List<string> SearchByGenre(string userInput)
        {

            using (var context = new MovieDBContext())
            {
                Console.WriteLine($"Here are a list of { userInput } movies.\nPlease wait...,");
                var movie = context.Movies.Where(m => m.Genre == userInput).ToList();

                List<string> result = new List<string>();
                Console.WriteLine(string.Format("\t{0,-25}{1,-25}", "Title", "Runtime"));
                foreach (var movies in movie)
                {
                    if (movies.Genre == "")
                    {
                        Console.WriteLine("I made it here");
                    }
                    string formattedResult = string.Format("\t{0,-25}{1,-25}", movies.Title, movies.Runtime);
                    result.Add(formattedResult);
                }
                return result;
            };
        }

        static List<string> SearchByTitle(string userInput)
        {
            Console.WriteLine("Here is your movie. Enjoy! ");
            using (var context = new MovieDBContext())
            {

                var movie = context.Movies.Where(m => m.Title == userInput).ToList();

                List<string> result = new List<string>();
                Console.WriteLine(string.Format("\t{0,-25}{1,-15}{2,-15}", "Title", "Genre", "Runtime"));
                foreach (var movies in movie)
                {
                    string formattedResult = string.Format("\t{0,-25}{1,-15}{2,-15}", movies.Title, movies.Genre, movies.Runtime);
                    result.Add(formattedResult);
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
                    new Movie("Men in Tights", "Comedy", 143.9),
                    new Movie("Olympus Has Fallen", "Action", 141.8),
                    new Movie("Law of Abiding Citizen", "Action", 163.15),
                    new Movie("Blood and Bone", "Action", 128.15),
                    new Movie("Hangover", "Comedy", 153.15),
                    new Movie("Bruno", "Comedy", 153.15),
                };
                foreach (Movie m in movieList)
                {
                    context.Movies.Add(m);
                    Console.WriteLine($"{m.Title} has been saved!");
                    context.SaveChanges();
                }
            };
        }

        protected static int origRow;
        protected static int origCol;

        public static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.WriteLine(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear(); // why console clear has to be there - I don't want it
                Console.WriteLine(e.Message);
            }
        }
    }

    public class Validation
    {
        public static string YesNoChoice()
        {
            string choice;
            while (true)
            {
                choice = Console.ReadLine().Trim().ToLower(); ;
                if (choice == "y")
                {
                    break;
                }
                else if (choice == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please choose y/n:");
                }
            }
            return choice;
        }
    }
}
