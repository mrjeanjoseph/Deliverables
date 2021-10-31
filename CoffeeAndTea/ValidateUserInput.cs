using System;

namespace CoffeeAndTea
{
    class ValidateUserInput
    {
        public static bool AboveZero(int x)
        {
            if (x > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool StringNotEmpty(string value)
        {
            if (value == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool StringIsNumeric(string value)
        {
            try
            {
                int x = int.Parse(value);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool ValidatorInput(int userInput, int counter)
        {
            bool output = true;
            if (userInput <= 0 || userInput > counter)
            {
                Console.WriteLine("Not less than 0 and more than the list");
                output = false;
            }
            return output;
        }

        public static bool GetUserValues(int userInput)
        {
            bool output = true;
            while (true)
            {
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    if (userInput < 0 || userInput > 12)
                    {
                        return false;
                        throw new Exception("Please enter a value between as displayed in the list");
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.Write("Value entered is not a number. \nPlease try again: ");
                }
                catch (Exception error)
                {
                    Console.Write(error.Message);
                }
            }
            return output;
        }

        public static int UserSelection()
        {
            int x;
            while (true)
            {
                try
                {
                    // This should loop our list from 1 -12
                    x = int.Parse(Console.ReadLine());
                    if (x <= 0 || x >= 13)
                    {
                        Console.WriteLine("Invalid entry. Choose a number between 1-12 from our menu");
                    }
                    else
                    {
                        break; // break to return below
                    }
                }
                catch (Exception) // This will catch format issues.
                {
                    Console.WriteLine("That was not a number. Choose between 1-12 from our menu");
                }
            }
            return x;
        }

        public static string ValidateUserName()
        {
            string str;
            while (true)
            {
                try
                {
                    str = Console.ReadLine();
                    if (StringIsNumeric(str) == true)
                    {
                        Console.WriteLine("Invalid entry. Please enter your name");
                    }
                    else if (str == "")
                    {
                        Console.WriteLine("Name field cannot be empty.");
                    }
                    else if (str.Contains("*/-+~!@#$%^&*()_+="))
                    {
                        Console.WriteLine("Name field cannot be empty.");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e) // This will catch format issues.
                {
                    Console.WriteLine("Invalid entry. Please enter your name");
                }
            }
            return str;
        }

    }
}
