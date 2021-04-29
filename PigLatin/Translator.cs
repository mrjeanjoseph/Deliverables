using System;
using System.Collections.Generic;

namespace PigLatin
{
    class Translator
    {
        private string _words;

        public string Words
        {
            get { return this._words; }
            set { this._words = value; }
        }

        public Translator(string words)
        {
            this._words = words;
            ToPigLatin(words);
        }

        public Translator()
        {
            // default constructor
        }
        public override string ToString()
        {
            return $"{this._words}";
        }

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().ToLower().Trim();
            return input;
        }

        bool HasSpecialChars(string c)
        {

            
            if (c.Contains("@.-$^&!#%*)(_+=/+"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        string IsVowel(string vowels = "aeiou")
        {
            return vowels;
        }

        void ToPigLatin(string words)
        {
            //HasSpecialChars(words);
            List<string> output = new List<string>();

            //Handle going through each words
            foreach (string eachWord in words.Split(' ')) //Replaced the forloop for an foreach loop
            {
                string firstLetter = eachWord.Substring(0, 1);
                string postFix = eachWord.Substring(1, eachWord.Length - 1);

                if (eachWord.Contains("@"))
                {
                   //Console.WriteLine("I am here");
                    output.Add(eachWord);
                }
                else if (IsVowel().IndexOf(firstLetter) == -1)
                {
                    output.Add($"{ postFix }{ firstLetter }ay");
                }
                else
                {
                    output.Add($"{ eachWord }way");
                }
            }
            //return $" {output}"; Are you kidding me?
            Console.WriteLine(string.Join(" ", output));
            //return string.Join(" ", output);

            // breakpoint not making it here
            //char firstLetter = word[0];
            //string output;
            //if (vowels.Contains(firstLetter))
            //{
            //    output = word + "way";
            //}
            //else
            //{
            //    int vowelIndex = -1;

            //    //Handle going through all the consonants
            //    for (int i = 1; i <= word.Length; i++)
            //    {
            //        if (vowels.Contains(word[i]))
            //        {
            //            vowelIndex = i;
            //            break;
            //        }
            //    }
            //    string sub = word.Substring(vowelIndex + 1);
            //    string postFix = word.Substring(0, vowelIndex - 1);

            //string postFix = word.Substring(0, vowelIndex + 1);

                //string postFix = word.Substring(0, vowelIndex + 1);

            //    output = sub + postFix + "ay";
            //}
            //return output;
        }

    }
}

