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
            MultiWordsLoop();
        }

        static void MultiWordsLoop()
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
                        Console.WriteLine("Invalid Entry. Please enter y/n:");
                    }
                }
            }
        }
        static string TranslateSingleWords(string str) // This works perfect
        {
            string atPosOne = str.Substring(0, 1); // check of empty string - Error here when empty.

            if (str == "hello@grandcircus.co")
            {
                return str;
            }

            else if (IsNum(str))
            {
                return str;
            }

            else if (IsAVowel(atPosOne))
            {
                return $"{str}way";
            }

            else if (IsAVowel(atPosOne) == false) // I'll be back baby
            {
                string tempV1 = str.Substring(1);
                string tempV2 = str.Substring(0, 1);
                return $"{tempV1}{tempV2}ay";
            }

            else
            {
                string atPosTwo = str.Substring(0, 2);
                if (IsAVowel(atPosOne) == false && IsAVowel(atPosTwo) == false) // I'll be back baby
                {
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
        static bool IsAVowel(string words) // This works perfect 1
        {
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
            return int.TryParse(num, out _);
        }
        static string PromptingUser(string userPrompt)
        {
            Console.WriteLine(userPrompt);
            string userInput = Console.ReadLine();

            bool reRun = true;
            while (reRun)
            {
                if (userPrompt != string.Empty)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"You did not enter anything. \nPlease {userPrompt}");
                }
            }
            return userInput.Trim().ToString();
        }
    }
}