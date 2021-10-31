using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Movie
    {
        private string _title;
        private string _category;

        public string Title
        {
            get { return _title; }
            set { this._title = value; }
        }

        public string Category
        {
            get { return _category; }
            set { this._category = value; }
        }

        public Movie(string title, string category)
        {
            this._category = category;
            this._title = title;
        }
    }
}
