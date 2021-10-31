using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class ListOfMovies
    {
        //fields
        private string _name;
        private List<Movie> _inventory;

        //properties
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public List<Movie> Inventory
        {
            get { return this._inventory; }
            set { this._inventory = value; }
        }

        //Constructor
        public ListOfMovies(string name)
        {
            this._name = name;
            MovieList();
        }

        private void MovieList()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie("Finding Neemo", "Animated"),
                new Movie("The Godfather", "Drama"),
                new Movie("Children of the corn", "Horror"),
                new Movie("Terminator", "Scifi"),
                new Movie("Frozen", "Animated"),
                new Movie("Predator", "Scifi"),
                new Movie("Chucky", "Horror"),
                new Movie("Too Fast", "Drama"),
                new Movie("Star Wars", "Scifi"),
                new Movie("Close Encounters of the Third Kind", "Horror")
            };
            this._inventory = movies;
        }

        public string Greeting()
        {
            string welcome = $"Welcome to {this._name} app!";
            string intro = $"\nThere are 10 movies in this list.";
            return $"{ welcome }\n{ intro }";
        }

        public void DisplayAllMovies()
        {
            string formattedList = string.Format("{0, -15} {1, 5}", "Category", "Movie Title");
            string dashesAdded = string.Format("{0, -15} {1, 5}", "--------", "-----------");
            Console.WriteLine($"{ formattedList }\n{ dashesAdded }");
            foreach (Movie movies in this._inventory)
            {
                formattedList = string.Format("{0, -15} {1, 5}", movies.Category, movies.Title);
                Console.WriteLine(formattedList);
            }
        }

        public string GetUserInput(string UserPrompt)
        {
            Console.WriteLine(UserPrompt);
            return UserPrompt = Console.ReadLine();
        }

        public Movie GetMoviesByCategory(string searching)
        {
            Movie category = null;
            foreach (Movie movies in this.Inventory)
            {
                if (movies.Category.ToLower() == searching.ToLower())
                {
                    category = movies;
                }
            }

            if (category != null)
            {
                Console.WriteLine($"Here's a list of movies from the { searching } category:");
                foreach (Movie movies in this._inventory)
                {
                    if (searching.ToLower() == movies.Category.ToLower())
                    {
                        Console.WriteLine($" { movies.Title }"); //This has to display a list of movies based on the category
                    }
                }
            }
            else
            {
                Console.WriteLine($"No movies was found under { searching } category.\nPlease try again");
                GetMoviesByCategory(GetUserInput(null));
            }
            return category;
        }
    }
}
