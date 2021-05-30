using System;
using System.Collections.Generic;
using System.Text;

class TestPractice
{
    static void ReverseStrings() // This peice of code reverses a tring
    {
        string str, Revstr = " ";
        int len;

        Console.Write("Enter a String:");
        str = Console.ReadLine();
        len = str.Length - 1;
        while (len >= 0)
        {
            Revstr += str[len];
            len--;
        }
        Console.WriteLine($"Reverse String is { Revstr }.");
    }
    static void Question3()
    {
        char a = 'A';
        string b = "a";

        Console.WriteLine(Convert.ToInt32(a));
        Console.WriteLine(Convert.ToInt32(Convert.ToChar(b)));
        Console.ReadLine();
    }
    static long Question2()
    {
        int num1 = 20000;
        int num2 = 50000;
        long total;
        total = num1 + num2;

        return total;

    }
    static void Question1()
    {
        var dayCode = "MTWFS";
        var daysArray = new List<string>();
        var list = new Dictionary<string, string>
        {
            {"M","Monday"},
            {"T","Tuesday"},
            {"W","Wednesday"},
            {"R","Thursday"},
            {"F","Friday"},
            {"S","Saturday"},
            {"U","Sunday"}
        };
        for (int i = 0, max = dayCode.Length; i < max; i++)
        {
            var tmp = dayCode[i].ToString();
            if (list.ContainsKey(tmp))
            {
                daysArray.Add(list[tmp]);
            }
        }
        Console.WriteLine(string.Join("\n", daysArray));
        Console.ReadLine();
    }
    static void SwapTwoNumbers()
    {
        int num1, num2, tempNum;

        Console.WriteLine("\nEnter the first number: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("\nEnter the second number: ");
        num2 = int.Parse(Console.ReadLine());

        tempNum = num1;
        num1 = num2;
        num2 = tempNum;

        Console.WriteLine("\nAfter Swapping: ");
        Console.WriteLine($"\nFirst Number: {num1 }");
        Console.WriteLine($"\nSecond Number:  { num2 } ");
    }
    static void NumberOfNums()
    {
        int m, countNums = 0, numToCheck;
        Console.WriteLine("How many number to list: ");
        m = int.Parse(Console.ReadLine());

        int[] a = new int[m];
        Console.WriteLine("Provide List of numbers: ");
        for (int i = 0; i < m; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("what number are you checking: ");
        numToCheck = Convert.ToInt32(Console.ReadLine());
        foreach (int o in a)
        {
            if (o == numToCheck)
            {
                countNums++;
            }
        }
        Console.WriteLine($"Number of {numToCheck}'s from this list = {countNums}");
    }
    static void BinaryTriangle()
    {
        int input, lastIn = 0;

        input = int.Parse(Console.ReadLine());
        for (int i = 1; i <= input; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (lastIn == 1)
                {
                    Console.Write(" X");
                    lastIn = 0;
                }
                else if (lastIn == 0)
                {
                    Console.Write(" Y");
                    lastIn = 1;
                }
            }
            Console.Write("\n");
        }
    }
    static void EvenOrOdd()
    {
        int i;
        Console.Write("Enter a Number: ");
        i = int.Parse(Console.ReadLine());
        if (i % 2 == 0)
        {
            Console.Write("Entered Number is an Even Number");
            Console.Read();
        }
        else
        {
            Console.Write("Entered Number is an Odd Number");
            Console.Read();
        }
    }
}