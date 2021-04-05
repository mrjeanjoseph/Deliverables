using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the rectangle");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle");
            int width = int.Parse(Console.ReadLine());

            int result = length * width;
            Console.WriteLine($"The area of the rectangle is: {result}");

            Console.ReadLine();
        }
    }
}
