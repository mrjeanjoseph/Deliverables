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
            int count = 0;
            string duplicateMessage = "I’m sorry but you have already said that";
            List<string> tempData = new List<string>(2) { "hello", "hello there", "sup", "bye" };

            do
            {
                Console.Write("What do you want to say to the chatbot: ");
                tempUserInput = Console.ReadLine();
                string userInput = tempUserInput.ToLower();





                if (userInput == tempData[0])
                {
                    count++;
                    if (count == 1)
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
                    count++;
                    if (count == 1)
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
                    if (count >= 2)
                    {
                        Console.WriteLine(duplicateMessage);
                    }
                    else
                    {
                        Console.WriteLine("\tGeneral Kenobi");
                    }
                }

            } while (tempUserInput != tempData[3]);

            Console.WriteLine("Good bye!");
        }
    }
}
