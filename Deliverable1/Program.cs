using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal fsValue = 3.5m,
            memesValue = 5.0m, tempval;
            
            string correctUnit = "";
            string userPrompt;

            do
            {
                Console.Write("(Inch, Fidget Spinners, Foot, Memes) \n" +
                                "Choose from one of the measurement type above: ");
                string userInputMsrmt = Console.ReadLine();

                Console.Write("Enter an amount: ");
                decimal userInputAmnt = Convert.ToDecimal(Console.ReadLine());

                if (userInputMsrmt.ToLower() == "inch")
                {
                    tempval = fsValue * userInputAmnt;
                    correctUnit = $"{Convert.ToString(tempval)} fidget spinners";
                }
                else if (userInputMsrmt.ToLower() == "fidget spinners")
                {
                    tempval = userInputAmnt / fsValue;
                    correctUnit = $"{Convert.ToString(tempval)} inch";
                }
                else if (userInputMsrmt.ToLower() == "foot")
                {
                    tempval = memesValue * userInputAmnt;
                    correctUnit = $"{Convert.ToString(tempval)} Memes";
                }
                else if (userInputMsrmt.ToLower() == "memes")
                {
                    tempval = userInputAmnt /memesValue ;
                    correctUnit = $"{Convert.ToString(tempval)} foot";
                }
                Console.WriteLine($"If input is { userInputAmnt } { userInputMsrmt }, output is { correctUnit }.");

                Console.WriteLine("=======================================");
                Console.WriteLine("Do you wish to do another calculation? ");
                userPrompt = Console.ReadLine();

                Console.Beep();
                Console.Clear();

            } while (userPrompt.ToLower() == "yes");
        }
    }
}
