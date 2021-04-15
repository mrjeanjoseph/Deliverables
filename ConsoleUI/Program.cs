using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to GC Casino!".ToUpper());
            bool playAgain = true;
            while (playAgain)
            {
                int userRolled = GetUserValues();

                int dice1 = RandomNumberGenerator(userRolled);
                int dice2 = RandomNumberGenerator(userRolled);

                Console.WriteLine($"you rolled a {dice1} and a {dice2} ({dice1 + dice2} Total)");
                Console.WriteLine(DisplayingResultValues(dice1, dice2));

                // Check if they want to buy again
                Console.Write("Roll again? (y/n): ");
                while (true)
                {
                    string roolAgain = Console.ReadLine();
                    Console.Clear();
                    if (roolAgain == "y")
                    {
                        break;
                    }
                    else if (roolAgain == "n")
                    {
                        playAgain = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please choose y/n:");
                    }
                }
            }
            Console.WriteLine("Thanks for playing!!");
        }
        static string DisplayingResultValues(int dice1, int dice2)
        {
            int total = dice1 + dice2;


            if (dice1 == 1 && dice2 == 1)
            {
                return "Snake Eyes";
            }
            else if ((dice1 == 1 && dice2 == 2) || (dice1 == 2 && dice2 == 1))
            {
                return "Ace Deuce";
            }
            else if (dice1 == 6 && dice2 == 6)
            {
                return "Box Cars";
            }
            else if (total == 7 || total == 11)
            {
                return "Win";
            }

            if (total == 2 || total == 3 || total == 12)
            {
                return "Craps";
            }
            else
            {
                return null;
            }
        }
        static int RandomNumberGenerator(int userRolled)
        {
            Random getRandNum = new Random();
            int rolls = getRandNum.Next(1, userRolled);
            return rolls;
        }
        static int GetUserValues()
        {
            Console.WriteLine("How many sides should each die have?");
            int chosenvalues;
            while (true)
            {
                try
                {
                    chosenvalues = int.Parse(Console.ReadLine());
                    if (chosenvalues < 1)
                    {
                        throw new Exception("Value entered is too low");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a numerical value to proceed");
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            return chosenvalues;
        }
    }
}
