using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleUI
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public double? Runtime { get; set; }

        //Creating the constructor to use the list of movie option
        public Movie() { }

        public Movie(string title, string genre, double runtime)
        {
            this.Title = title;
            this.Genre = genre;
            this.Runtime = runtime;
        }  
    }
}
