using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings;

class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("What is your age: ");
        int age = Convert.ToInt32(Console.ReadLine());         

        Console.WriteLine("What is your favorite color: ");
        string color = Console.ReadLine();


        Console.WriteLine($"Name: " + name);
        Console.WriteLine($"Age: " + age);
        Console.WriteLine($"Color: " + color);

        Console.ReadLine();
    }
}
