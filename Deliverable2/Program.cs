using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            TheSolution();
            Console.ReadLine();
        }
        static void TheSolution()
        {
            string tempUserInput;
            int count1 = 0, count2 = 0, count3 = 3;
            string duplicateMessage = "I’m sorry but you have already said that";
            List<string> tempData = new List<string>(2) { "hello", "hello there", "sup", "bye" };

            do
            {
                Console.Write("What do you want to say to the chatbot: ");
                tempUserInput = Console.ReadLine();
                string userInput = tempUserInput.ToLower();

                if (userInput == tempData[0])
                {
                    count1++;
                    if (count1 == 1)
                    {
                        Console.WriteLine("\tHi good to see you.");
                    }
                    else
                    {
                        Console.WriteLine(duplicateMessage);
                    }
                }

                else if (userInput == tempData[1])
                {
                    count2++;
                    if (count2 == 1)
                    {
                        Console.WriteLine("\tI am good");
                    }
                    else
                    {
                        Console.WriteLine(duplicateMessage);
                    }
                }

                else if (userInput == tempData[2])
                {
                    count3++;
                    if (count3 == 1)
                    {
                        Console.WriteLine("\tGeneral Kenobi");
                    }
                    else
                    {
                        Console.WriteLine(duplicateMessage);
                    }
                }

            } while (tempUserInput != tempData[3]);

            Console.WriteLine("Good bye!");
        }
    }
}
