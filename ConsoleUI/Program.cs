using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PopulateMovies();
            Console.WriteLine("Saved");
            Console.ReadLine();
        }

        static void PopulateMovies()
        {
            using (var context = new MovieDBContext())
            {
                Movie m1 = new Movie()
                {
                    Title = "Finding Neemo",
                    Genre = "Animated",
                    Runtime = 122.5
                };
                Movie m2 = new Movie()
                {
                    Title = "Too Fast",
                    Genre = "Action",
                    Runtime = 131.1
                };

                context.Movies.Add(m1);
                context.Movies.Add(m2);
                context.SaveChanges();
            };
        }
    }
}
