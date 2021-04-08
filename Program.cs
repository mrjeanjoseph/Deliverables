using System;

namespace Lab4Exponents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO 'LEARN YOUR SQUARES AND CUBES!'");
            Calculation();
            
        }
        static void Calculation()
        {
            bool promptUserAgain = true;
            while (promptUserAgain)
            {
                int userInput = NumberValidation();

                Console.WriteLine("Numbers\tSquared\tCubed\t");
                Console.WriteLine("=======\t=======\t=======\t");

                string sqResult;
                string cubeResult;

                for (int i = 1; i <= userInput; i++)
                {
                    sqResult = GetTheSquare(i).ToString();
                    cubeResult = GetTheCube(i).ToString();
                    Console.WriteLine($"{ i }\t{ sqResult }\t{ cubeResult }");
                }

                //Prompting the user to try another number.
                Console.WriteLine("Enter y/n to continue:");
                while (true)
                {
                    string continueRunning = Console.ReadLine().Trim().ToLower();
                    if (continueRunning == "y")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (continueRunning == "n")
                    {
                        promptUserAgain = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter y/n.");
                    }
                }
            }
        }
        static int NumberValidation()
        {
            Console.WriteLine("Enter an number greater than 0.");
            int userInput;
            while (true)
            {
                userInput = int.Parse(Console.ReadLine());
                if (userInput <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid entry. Enter an number greater than 0.");
                }
                else
                {
                    break;
                }
            }
            return userInput;
        }
        static int GetTheSquare(int userinput)
        {
            int output = userinput * userinput;
            return output;
        }
        static int GetTheCube(int userinput)
        {
            int output = userinput * userinput * userinput;
            return output;
        }
    }
}