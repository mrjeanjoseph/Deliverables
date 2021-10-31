using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class CountryListView
    {
        //field
        private List<Country> _countries;
        //Property
        public List<Country> Countries
        {
            get { return this._countries; }
            set { this._countries = value; }
        }

        //Constructor
        public CountryListView(List<Country> countryList)
        {
            this._countries = countryList;            
        }

        //Methods
        public void Display()
        {
            Console.WriteLine("Country:");

            for (int i = 1; i <= _countries.Count; i++)
            {
                Console.WriteLine($"{i} {_countries[i-1].Name }");
            }

            // There are two ways of getting that list.
            //int counter = 1;
            //foreach (Country country in _countries)
            //{
            //    Console.WriteLine($"{ counter }. {country.Name}");
            //    counter++;
            //}
        }
    }
}
