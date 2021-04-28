using System;
using System.Linq;

namespace PigLatin
{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string userInput = Translator.GetInput("Input a word or sentence to translate to pig Latin");

                string translation = ToPigLatin(userInput);
                Console.WriteLine(translation); 
            } while (true);
        }

        public static bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            return c.ToString() == vowels.ToString();
        }

        public static string CheckForSpecialChar(string word) // will use a short line of code for this one.
        {
            char[] specialChars = { '@', '.', '-', '$', '^', '&' };
            word = word.ToLower();
            foreach (char c in specialChars)
            {
                foreach (char w in word)
                {
                    if (w == c)
                    {
                        Console.WriteLine("That word has special characters, we will return it as is");
                        word = word.Trim();
                    }
                }

            }

            return word;
        }


        public static string CheckForNoVowels(string word)
        {
            bool noVowels = true;
            foreach (char letter in word)
            {
                if (IsVowel(letter))
                {
                    noVowels = false;
                }
            }

            if (noVowels)
            {
                // the code reaches here and returned all words.
                return word;
            }
            else
            {
                return "I reached here!"; // address this issue.                
            }
        }

        public static string ToPigLatin(string word)
        {
            CheckForSpecialChar(word);

            CheckForNoVowels(word);


            // My breakpoint are not making it here
            char firstLetter = word[0];
            string output;
            if (IsVowel(firstLetter) == false)
            {
                output = word + "ay";
            }
            else
            {
                int vowelIndex = -1;
                string sub = word.Substring(vowelIndex + 1);
                string postFix = word.Substring(0, vowelIndex - 1);

                //Handle going through all the consonants
                for (int i = 1; i <= word.Length; i++)
                {
                    if (IsVowel(word[i]) == true)
                    {
                        vowelIndex = i;
                        break;
                    }
                }



                output = sub + postFix + "ay";
            }
            return output;
        }
    }
}
