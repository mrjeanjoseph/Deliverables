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
        public void Display(List<Country> countryList)
        {
            Console.WriteLine("Name:\tPrice");
            Console.WriteLine("====\t======");

            foreach (Country item in countryList)
            {
                Console.WriteLine(item);
                // better
            }
        }
    }
}
