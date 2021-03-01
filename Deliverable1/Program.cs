using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal milhipValue = 3.5m;
            decimal memesValue = 5.0m;
            decimal correctUnit = 0;
            string userPrompt;

            Console.Write("(Imperial, Milhip, Foot, Memes) \n" +
                "Enter a measurement type: ");
            string userInputMsrmt = Console.ReadLine();
            
            Console.Write("Enter an amount: ");
            double userInputAmnt = Convert.ToDouble(Console.ReadLine());

            if (userInputMsrmt.ToLower() == "imperial")
            {
                correctUnit = milhipValue * Convert.ToDecimal(userInputAmnt);
            }
            else if (userInputMsrmt.ToLower() == "milhip")
            {
                correctUnit = milhipValue / Convert.ToDecimal(userInputAmnt);
            }
            else if (userInputMsrmt.ToLower() == "foot")
            {
                correctUnit = memesValue * Convert.ToDecimal(userInputAmnt);
            }
            else if (userInputMsrmt.ToLower() == "memes")
            {
                correctUnit = memesValue / Convert.ToDecimal(userInputAmnt);
            }

            Console.WriteLine($"If input is: { userInputAmnt }, output is { correctUnit } { userInputMsrmt }" );

            Console.ReadLine();
        }
    }
}
