using System;
using System.Linq;
using System.Text;

namespace CapstonePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the 'Pig Latin Translator!' ");
            FinalTranslation();
        }
        static void FinalTranslation()
        {
            bool reRunProgram = true; ;
            while (reRunProgram)
            {
                string userInput = PromptingUser("\nEnter a line to be translated: ");
                string[] splitWords = userInput.Split(" ");
                for (int i = 0; i < splitWords.Length; i++)
                {
                    Console.Write($"{ TranslateSingleWords(splitWords[i]) } ");
                }

                Console.WriteLine("\nDo you want to translate another word?: (y/n)");
                while (true)
                {
                    string userinput2 = Console.ReadLine();
                    Console.Clear();
                    if (userinput2.ToLower() == "y")
                    {
                        break;
                    }
                    else if (userinput2.ToLower() == "n")
                    {
                        reRunProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You did not enter anything.\nPlease enter y/n:");
                    }
                }
            }
        }
        static string TranslateSingleWords(string str)
        {
            string atPosOne = str.Substring(0, 1);

            if (str == "hello@grandcircus.co")
            {
                return str;
            }

            else if (IsNum(str))
            {
                return str;
            }

            else if (FirstVowelCheck(atPosOne))
            {
                return $"{str}way";
            }

            else if (FirstVowelCheck(atPosOne) == false) //Checking the first string
            {
                string tempV1 = str.Substring(1);
                string tempV2 = str.Substring(0, 1);
                return $"{tempV1}{tempV2}ay";
            }

            else
            {
                string atPosTwo = str.Substring(0, 2);
                if (FirstVowelCheck(atPosOne) == false && FirstVowelCheck(atPosTwo) == false)
                {  //Checking the second position withing the string
                    string tempV1 = str.Substring(2);
                    string tempV2 = str.Substring(0, 2);
                    return $"{tempV1}{tempV2}ay";
                }
                else
                {
                    return null;
                }
            }
        }
        static bool FirstVowelCheck(string words)
        { //Could have used countains method but wanted to write my own 
            string w = words.Trim().ToLower();
            if (w.StartsWith("a"))
            {
                return true;
            }
            else if (w.StartsWith("e"))
            {
                return true;
            }
            else if (w.StartsWith("i"))
            {
                return true;
            }
            else if (w.StartsWith("o"))
            {
                return true;
            }
            else if (w.StartsWith("u"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsNum(string num)
        {
            return int.TryParse(num, out _); // Returns true if is a number
        }
        static string PromptingUser(string userPrompt)
        {
            bool reRun = true; // Rerun the program if empty string
            Console.WriteLine(userPrompt);
            string userInput = "";
            while (reRun)
            {
                userInput = Console.ReadLine();
                if (userInput == "")
                {
                    Console.WriteLine($"You did not enter anything. \nPlease enter a word or a phrase");
                    reRun = true;
                }
                else
                {
                    break; // Break away from the while loop
                }
            }
            return userInput.Trim().ToString();
        }
    }
}