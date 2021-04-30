using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController countryController = new CountryController();
            Country c = new Country("US", "North A", new List<string> { "red", "white", "blue" });

            countryController.CountryAction(c);
        }
    }
}
