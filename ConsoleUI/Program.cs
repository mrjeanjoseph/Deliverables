using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            Random getRandNum = new Random();

            while (true)
            {
                int userRolled = GetUserValues();
                int dice1 = getRandNum.Next(0, userRolled);
                int dice2 = getRandNum.Next(0, userRolled);

                Console.WriteLine($"you rolled a {dice1} and a {dice2} ({dice1 + dice2} Total)");
                Console.WriteLine(DisplayingValues(dice1, dice2)); 

            }
        }

        static string DisplayingValues(int dice1, int dice2)
        {
            int total = dice1 + dice2;
            
            if (total == 2 || total == 3 || total == 12)
            {
                return "Craps";
            }
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
            else if (dice1 == 7 || dice2 == 11 || dice1 == 11 || dice2 == 11)
            {
                return "Win";
            }
            else
            {
                return null;
            }
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
                    throw new Exception("Please enter a numerical value to proceed");
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            return chosenvalues;
        }
        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Grand Circus Casino!" + Environment.NewLine + Environment.NewLine);
        }
    }
}
