using System;
using System.Linq;

namespace ClassroomDb
{
    class InputValidation
    {
        static bool IsNum(string num)
        {
            return int.TryParse(num, out _);
        }
        public static string YesNoChoice()
        {
            string choice;
            while (true)
            {
                choice = Console.ReadLine().Trim().ToLower(); ;
                if (choice == "y")
                {
                    break;
                }
                else if (choice == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please choose y/n:");
                }
            }
            return choice;
        }
        public static int IntIsValidated()
        {
            using (var context = new ClassroomDbContext())
            {
                int num;
                int StudsCount = context.Students.Count() + 1;
                string message = $"Choose a number between 1 and { StudsCount }";
                
                while (true)
                {
                    try
                    {
                        num = int.Parse(Console.ReadLine());
                        if (num < 1)
                        {
                            throw new Exception($"Value entered is less than 1. \n{ message }.");
                        }
                        else if (num > StudsCount)
                        {
                            throw new Exception($"That student does not exist. \n{ message }.");
                        }
                        else
                        {                            
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid entry. \nPlease try again: ");
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
                }
                return num;
            }
        }

        public static void ConsoleCleared(int val)
        {
            Console.SetCursorPosition(0, Console.CursorTop - val); // Look into how many lines can cleared
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - val);
        }
    }
}
