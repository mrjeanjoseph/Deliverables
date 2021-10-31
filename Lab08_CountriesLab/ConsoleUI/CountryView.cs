using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class CountryView
    {
        private Country _displayCountry;

        public Country DisplayCountry
        {
            get { return this._displayCountry; }
            set { this._displayCountry = value; }
        }
        public CountryView(Country country)
        {
            this._displayCountry = country;
        }

        public void Display()
        {
            Console.WriteLine(string.Format("{0, -15} {1, -20} {2, 0}", "Name", "Continent", "Colors"));
            Console.WriteLine(string.Format("{0, -15} {1, -20} {2, 0}", this._displayCountry.Name, this._displayCountry.Continent, string.Join(", ", this._displayCountry.Colors)));
        }
    }
}