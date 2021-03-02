using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int duplicateInput = 0;
            string duplicateMessage = "I’m sorry but you have already said that";
            do
            {
                Console.Write("What do you want to say to the bot: ");
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "hello")
                {
                    if (duplicateInput < 1)
                    {
                        Console.WriteLine("\tHi good to see you.");
                    }
                    else
                    {
                        Console.WriteLine(duplicateMessage);
                    }
                }
                else if (userInput.ToLower() == "sup")
                {
                    Console.WriteLine("\tI am good");
                }
                else if (userInput.ToLower() == "hello there")
                {
                    Console.WriteLine("\tGeneral Kenobi");
                }
            } while (userInput != "bye");

            Console.WriteLine("Good bye!");
            Console.ReadLine();
        }
    }
}
