using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal milhipValue = 3.5m;
            decimal memesValue = 5.0m;
            string correctUnit = "";
            decimal tempval;
            string userPrompt;

            do
            {
                Console.Write("(Imperial, Milhip, Foot, Memes) \n" +
        "Enter a measurement type: ");
                string userInputMsrmt = Console.ReadLine();

                Console.Write("Enter an amount: ");
                double userInputAmnt = Convert.ToDouble(Console.ReadLine());

                if (userInputMsrmt.ToLower() == "imperial")
                {
                    tempval = milhipValue * Convert.ToDecimal(userInputAmnt);
                    correctUnit = $"{Convert.ToString(tempval)} Milhip";
                }
                else if (userInputMsrmt.ToLower() == "milhip")
                {
                    tempval = milhipValue / Convert.ToDecimal(userInputAmnt);
                    correctUnit = $"{Convert.ToString(tempval)} imperial";
                }
                else if (userInputMsrmt.ToLower() == "foot")
                {
                    tempval = memesValue * Convert.ToDecimal(userInputAmnt);
                    correctUnit = $"{Convert.ToString(tempval)} memes";
                }
                else if (userInputMsrmt.ToLower() == "memes")
                {
                    tempval = memesValue / Convert.ToDecimal(userInputAmnt);
                    correctUnit = $"{Convert.ToString(tempval)} foot";
                }
                Console.WriteLine($"If input is: { userInputAmnt }, output is { correctUnit }.");

                Console.Write("Do you wish to do another calculation? ");
                userPrompt = Console.ReadLine();

            } while (userPrompt.ToLower() == "yes"); // TESTING INTEGRATION NOW!
        }
    }
}
