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
            Console.WriteLine($"{_displayCountry.Name }, {_displayCountry.Continent }, {string.Join(",", _displayCountry.Colors)} ");
        }
    }

}
