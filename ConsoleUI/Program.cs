using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester".ToUpper());
            int counter = 0;
            bool runProgram = true;
            while (runProgram && counter >= 0)
            {
                Circle circle = new Circle(2);

                Console.WriteLine(circle.CalculateFormattedCircumference());
                Console.WriteLine(circle.CalculateFormattedArea());
                counter++;

                Console.WriteLine("Would you like to try again?: y/n");
                while (true)
                {
                    string tryAgain = Console.ReadLine();
                    if (tryAgain == "y")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (tryAgain == "n")
                    {
                        runProgram = false;
                        Console.WriteLine($"Goodbye. You created { counter } Circle object(s)");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please try again. y/n");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
