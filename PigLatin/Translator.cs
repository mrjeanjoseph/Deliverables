using System;

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
        }

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().ToLower().Trim();
            return input;
        }

    }
}
