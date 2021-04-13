using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> listOfItems = new Dictionary<string, double>
            {
                {"apple", 5.99},
                {"banana", 1.98},
                {"cauliflower", 1.59},
                {"dragonfruit", 2.19},
                {"Elderberry", 1.79},
                {"figs", 2.09},
                {"grapefruit", 1.99},
                {"honeydew", 3.49}
            };
            List<string> itemsPurchased = new List<string>();
            List<double> pricesPerItem = new List<double>();

            Console.WriteLine("Welcome to Guenther's Market!");
            Console.WriteLine("Item\t\tPrice");
            Console.WriteLine("===========================");

            //Getting the menu
            foreach (KeyValuePair<string, double> kvp in listOfItems)
            {
                Console.WriteLine($"{kvp.Key}: \t{kvp.Value}");
            }

            Console.WriteLine("\n\nWhat item would you like to order?");

            while (true)
            {
                // Initial purchasing
                string userChoice = Console.ReadLine();
                double result;
                if (listOfItems.TryGetValue(userChoice, out result))
                {
                    itemsPurchased.Add(userChoice);
                    pricesPerItem.Add(result);
                    Console.WriteLine($"Adding {userChoice} to cart at {result}");
                }
                else
                {
                    Console.WriteLine($"Sorry, we don't have {userChoice}. Please try again.");
                }
            }

            // Check if they want to buy again
            Console.WriteLine("Would you like to order anything else (y/n)?");
            while (true)
            {
                string loopChoice = Console.ReadLine();
                if (loopChoice == "y")
                {
                    break;
                }
                else if (loopChoice == "n")
                {
                    //runApplication = false;
                    break;
                }
                else
                {
                    Console.WriteLine("that was not a valid choice");
                }
            }

            // Display receipt
            Console.WriteLine("Thank you for your order");
            Console.WriteLine("Here's what you got:");
            Console.WriteLine("Item\t\tPrice");
            Console.WriteLine("===========================");
            foreach (string item in itemsPurchased)
            {
                foreach (double price in pricesPerItem)
                {
                    Console.WriteLine($"{item}\t{price}");
                }
            }

            Console.ReadLine();
        }
    }
}
