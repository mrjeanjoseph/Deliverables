using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class CountryController
    {
        //Fields
        private List<Country> _countryDb = new List<Country>
        {
            new Country("Haiti", "Central America", new List<string>{"red", "blue"}),
            new Country("USA", "North America", new List<string>{"red", "white", "blue"}),
            new Country("India", "Asia", new List<string>{"Orange", "White", "Green", "Blue"}),
            new Country("Brazil", "South America", new List<string>{"Green", "Yellow", "blue", "white"}),
            new Country("Germany", "Europe", new List<string>{"Black", "Red", "Yello"}),
        };

        //Property
        public List<Country> CountryDb
        {
            get { return this._countryDb; }
            set { this._countryDb = value; }
        }

        public void CountryAction(Country c)
        {
            CountryView countryView = new CountryView(c);
            countryView.Display();
        }

        public void WelcomeAction()
        {
            bool runProgram = true;
            while (runProgram)
            {
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list: ");
                while (true)
                {
                    try
                    {
                        CountryListView countryListView = new CountryListView(_countryDb);
                        countryListView.Display();
                        int choice = int.Parse(Console.ReadLine());
                        if (choice >= _countryDb.Count && choice <= 0) // Make sure the user select from the list
                        {
                            Console.WriteLine("Invalid selection. Please select a number from the list");
                            continue;
                        }
                        CountryAction(_countryDb[choice - 1]);
                        break;
                    }
                    catch (Exception) // Catches all other errors
                    {
                        Console.Clear();
                        Console.WriteLine("An error has occur. \nPlease select a number from the list");
                        continue;
                    }
                }

                Console.WriteLine("Would like to learn about another country? y/n");
                while (true)
                {
                    string yesNo = Console.ReadLine();
                    if (yesNo == "y")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (yesNo == "n")
                    {
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Choose y/n to continue");
                    }
                }
            }
        }
    }
}
