using System;
using System.Collections.Generic;
using System.Linq;

namespace PigLatin
{
    public class Program
    {
        static void Main(string[] args)
        {
            string closeProgram = string.Empty;
            do
            {
                string userInput = Translator.GetInput("Input a word or sentence to translate to pig Latin");
                //Has been reworked to be an object instead of static methods
                Translator translator = new Translator(userInput);
                translator.ToString();
            } while (true);
        }
    }
}
