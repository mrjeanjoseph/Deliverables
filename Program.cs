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

            int area = length * width;
            int perimeter = (2*length + 2*width) ;

            Console.WriteLine($"Area of the rectangle is: {area}");
            Console.WriteLine($"Perimeter of the rectangle is: {perimeter}");
            Console.ReadLine();
            Console.WriteLine("Program has completed.");
        }
    }
}