using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO NUMBER ANALYZER APP");
            Console.WriteLine("==============================");

            bool runProgram = true;
            do
            {
                Console.WriteLine("Enter a number between 1 and 100");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput % 2 == 0 && userInput >= 2 && userInput < 25)
                {
                    Console.WriteLine($"Even and less than 25");
                }
                else if (userInput % 2 == 0 && userInput >= 26 && userInput <= 60)
                {
                    Console.WriteLine($"Even");
                }
                else if (userInput % 2 == 0 && userInput > 60)
                {
                    Console.WriteLine($"{ userInput } Even");
                }
                else
                {
                    Console.WriteLine($"{userInput } is Odd");
                }

                Console.WriteLine("Do you want to continue?: (y/n)");

                while (true)
                {
                    string loopCheck = Console.ReadLine();
                    if (loopCheck.ToLower() == "y")
                    {
                        break;
                    }
                    else if (loopCheck.ToLower() == "n")
                    {
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was not a y/n input");
                    }
                }

            } while (runProgram);

            Console.WriteLine("Thank you for using our Application.");
        }
    }
}
