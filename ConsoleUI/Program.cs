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
            string userInput = GetOnlyStrings("Please enter a word you would like to reverse:");
            Console.Write(ReverseWordsAndStrings(userInput));
            Console.ReadLine();
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
                        throw new Exception("You did not enter anything. \nPlease a word or a phrase.");
                    }
                    else if (specialChar.Contains(userInput))
                    {
                        throw new Exception("Special characters like:\n" + @"#$%&'()*+,-./:;<=>?@[\]^_`{|}~!" + " are not allowed\nPlease try again");
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
