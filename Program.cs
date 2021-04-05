using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");
            string userChoice;

            do
            {
                //Getting user's user value
                Console.WriteLine("Enter Length");
                double lenVal = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width");
                double widthVal = double.Parse(Console.ReadLine());

                //Calculating area and perimeter
                double pResult = Math.Round(2 * lenVal + 2 * widthVal);
                double aResult = Math.Round(lenVal * widthVal);

                //Displaying the result to user:
                Console.WriteLine($"Area: { aResult }\nPerimeter: { pResult }");
                Console.WriteLine($"Carpet Tiles: {Math.Round(aResult / 5, 3)}");
                Console.WriteLine($"Paint: {Math.Round(pResult / 5, 3)}");

                //Prompting the user again
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Would you like to calculate again?: ");
                userChoice = Console.ReadLine();

            } while (userChoice.ToLower() == "yes");
        }
    }
}
