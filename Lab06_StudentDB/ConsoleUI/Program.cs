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
            Console.WriteLine("Which student would you like to learn more about?");

            string[] nameArray = { "Sean", "Jason", "Kalai", "Jean", "Justin", "Alice", "Kristen", "Kamesha" };
            string[] cityArray = { "Plymouth", "Courtright", "Troy", "Lascahobas", "Wyoming", "Detroit", "Orange Park", "Detroit" };
            string[] foodArray = { "Pizza", "Dosa", "Baja Blast", "Fritay", "Sushi", "Mac and Cheese", "Macaroni and Cheese", "Tacos" };

            string userInput = UserPrompt("Enter anumber 1 - 20");

            bool reRunProgram = true;
            while (reRunProgram)
            {
                for (int i = 0; i <= nameArray.Length - 1; i++)
                {
                    if (Convert.ToInt32(userInput) == i + 1 && IsNum(userInput)) // The bug is right here - find it (maybe don't use a forloop
                    {
                        Console.WriteLine($"Student {userInput} is { nameArray[i] }.");

                        userInput = UserPrompt($"What would you like to know about {nameArray[i]}? \nEnter \"hometown\" or \"favorite food\".");
                        if (userInput.ToLower() == "hometown")
                        {
                            userInput = UserPrompt($"{nameArray[i]} is from {cityArray[i]}. Would you like to know more? (enter “yes” or “no”):");

                            if (userInput == "yes")
                            {
                                Console.WriteLine($"{nameArray[i]}'s favorite food is {foodArray[i]}.");
                                break;
                            }
                            else if (userInput == "no")
                            {
                                break;
                            }
                            else
                            {
                                userInput = UserPrompt("That was not a valid input. (enter “yes” or “no”): ");
                            }

                        }
                        else if (userInput.ToLower() == "favorite food")
                        {
                            userInput = UserPrompt($"{nameArray[i]}'s favorite food is {foodArray[i]}. Would you like to know more? (enter “yes” or “no”):");
                            if (userInput == "yes")
                            {
                                Console.WriteLine($"{nameArray[i]} is from {cityArray[i]}");
                                break;
                            }
                            else if (userInput == "no")
                            {
                                break;
                            }
                            else
                            {
                                userInput = UserPrompt("That was not a valid input. (enter “yes” or “no”): ");
                            }
                        }
                        else
                        {
                            userInput = UserPrompt("That data does not exist. Please try again. (enter “hometown” or “favorite food”)");
                        }
                    }
                    else if (Convert.ToInt32(userInput) > i + 8)
                    {
                        userInput = UserPrompt("That student does not exist. Please try again. (enter a number 1-20)");
                    }
                    else
                    {
                        reRunProgram = false;
                    }
                }

                userInput = UserPrompt("Do you want to learn about another student?: y/n");
                while (true)
                {
                    if (userInput == "y")
                    {
                        break;
                    }
                    else if (userInput == "n")
                    {
                        reRunProgram = false;
                        break;
                    }
                    else
                    {
                        userInput = UserPrompt("That was not a valid input.");
                    }
                }
            }
        }

        static bool IsNum(string num)
        {
            return int.TryParse(num, out _); // Returns true if is a number
        }

        static string UserPrompt(string userPrompt)
        {
            bool reRun = true; // Rerun the program if empty string
            Console.WriteLine(userPrompt);
            string userInput = "";
            while (reRun)
            {
                userInput = Console.ReadLine();
                if (userInput == "")
                {
                    Console.WriteLine($"You did not enter anything. \nPlease enter a value");
                    reRun = true;
                }
                else
                {
                    break; // Break away from the while loop
                }
            }
            return userInput.Trim().ToString();
        }
    }
}
