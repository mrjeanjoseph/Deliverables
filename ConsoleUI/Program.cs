using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Database();
            Console.ReadLine();
        }

        static void Database()
        {
            string[] nameArray = { "Sean", "Jason", "Kalai", "Jean", "Justin", "Alice", "Kristen", "Kamesha" };
            string[] cityArray = { "Plymouth", "Courtright", "Troy", "Lascahobas", "Wyoming", "Detroit", "Orange Park", "Detroit" };
            string[] foodArray = { "Pizza", "Dosa", "Fritay", "Baja Blast", "Sushi", "Mac and Cheese", "Macaroni and Cheese", "Tacos" };

            Console.WriteLine("Which student would you like to learn more about?");
            int userInput = int.Parse(UserPrompt("Enter anumber 1 - 20"));

            for (int i = 0; i <= nameArray.Length - 1; i++)
            {
                if (userInput == (i + 1)) // The bug is right here - find it
                {
                    Console.WriteLine($"Student {userInput} is { nameArray[i] }.");
                    string userInput2 = UserPrompt($"What would you like to know about {nameArray[i]}? \nEnter \"hometown\" or \"favorite food\".");
                    if (userInput2.ToLower() == "hometown")
                    {
                        userInput2 = UserPrompt($"{nameArray[i]} is from {cityArray[i]}. Would you like to know more? (enter “yes” or “no”):");
                        if (userInput2 == "yes")
                        {
                            Console.WriteLine($"{nameArray[i]}'s favorite food is {foodArray[i]}.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (userInput2.ToLower() == "favorite food")
                    {
                        userInput2 = UserPrompt($"{nameArray[i]}'s favorite food is {foodArray[i]}. Would you like to know more? (enter “yes” or “no”):");
                        if (userInput2 == "yes")
                        {
                            Console.WriteLine($"{nameArray[i]} is from {cityArray[i]}");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("That data does not exist. Please try again. (enter “hometown” or “favorite food”)");
                    }
                }
                else
                {
                    Console.WriteLine("That student does not exist. Please try again. (enter a number 1-20))");
                }
            }
        }

        static string UserPrompt(string userInput)
        {
            Console.WriteLine(userInput);
            userInput = Console.ReadLine();
            return userInput;
        }
    }
}
