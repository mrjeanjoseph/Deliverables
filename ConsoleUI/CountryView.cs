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
            Console.WriteLine($"{ this._displayCountry.Name }, { this._displayCountry.Continent }, { this._displayCountry.Colors }");
        }
    }

}
