using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class CountryController
    {
        //Fields
        private List<Country> _countryDb = new List<Country>
        {
            new Country("USA", "North America", new List<string>{"red", "white", "blue"}),
            new Country("Haiti", "Central America", new List<string>{"red", "white", "blue"}),
            new Country("India", "Asia", new List<string>{"Orange", "White", "Green", "Blue"}),
            new Country("Brazil", "South America", new List<string>{"Green", "Yellow", "blue", "white"}),
            new Country("Brazil", "South America", new List<string>{"Green", "Yellow", "blue", "white"}),
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
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list: ");
            bool runProgram = true;
            while (runProgram)
            {
                try
                {
                    CountryListView countryListView = new CountryListView(_countryDb);
                    countryListView.Display();
                    int choice = int.Parse(Console.ReadLine());
                    CountryAction(_countryDb[choice - 1]);
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("An error has occur. Please try again");
                    continue;
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
                        Console.WriteLine("That was not an option. Please select y/n");
                    }
                }
            }
        }

        public static string ValidateUserInput(int userInput, CountryListView x)
        {
            int output;
            while (true)
            {
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    if (userInput == this._coun)
                    {
                        return "Invalid";
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Not a number");
                    throw;
                }

            }
        }
    }
}
