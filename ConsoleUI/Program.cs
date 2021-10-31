using System;
using System.Collections;

namespace ConsoleUI
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    string str = Console.ReadLine();
        //    Reverse(str);

        //    Console.ReadLine();
        //}

        //static void Reverse(string str)
        //{
        //    for (int i = str.Length - 1; i >= 0; i--)
        //    {
        //        Console.Write(str[i]);
        //    }
        //}

        static void Main(string[] args)
        {
            bool runProgram = true;
            while (runProgram)
            {
                string userInput = GetOnlyStrings("Enter a word/phrase to be reversed: ");
                Console.Write(ReverseWordsAndStrings(userInput));

                Console.WriteLine("\nTranslate another word? y/n");
                while (true)
                {
                    userInput = Console.ReadLine().ToLower();

                    if (userInput == "y")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (userInput == "n")
                    {
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Your choices (y/n)");
                    }
                }
            }
            Console.WriteLine("Thank you for using our program. Piece!");
        }

        static string ReverseWordsAndStrings(string strings) // I need to make this a return value
        {
            Stack myStc = new Stack();

            string tempVar = "";
            //string result = "";
            for (int i = strings.Length - 1; i >= 0; i--)
            {
                if (strings[i] == ' ')
                {
                    myStc.Push(tempVar);
                    tempVar = "";
                }
                else
                {
                    tempVar += strings[i];
                }
            }
            myStc.Push(tempVar);
            while (myStc.Count != 0)
            {
                tempVar = (string)myStc.Peek();
                Console.Write(tempVar + " ");
                //result = $"{ tempVar } " + " ";
                myStc.Pop();
            }
            return null; // haha - returning null worked.
        }

        static string GetOnlyStrings(string Input)
        {
            Console.WriteLine(Input);
            string specialChar = @"#$%&'()*+,-./:;<=>?@[\]^_`{|}~!";
            string userInput;
            while (true)
            {
                try
                {
                    userInput = Console.ReadLine();
                    if (string.IsNullOrEmpty(userInput))
                    {
                        throw new Exception("This field is required. \nEnter a word or a phrase.");
                    }
                    else if (specialChar.Contains(userInput))
                    {
                        throw new Exception($"Special characters are not allowed. \nEnter a word or a phrase.");
                    }                    
                    else if ("0123456789".Contains(userInput))
                    {
                        throw new Exception("Numerical values are not allowed. \nEnter a word or a phrase.");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return userInput;
        }
    }
}
