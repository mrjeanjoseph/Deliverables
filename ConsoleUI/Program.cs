using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController countryController = new CountryController();            
            countryController.WelcomeAction();
            Console.ReadLine();
        }
    }
}
