using System;
using System.Linq;

namespace ClassroomDb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to classroom database");
            //CreateDb();
            DisplayAllDB();
            DisplayStudentDB();
            Console.WriteLine("Thank you for using out application");
            Console.ReadLine();
        }

        private static void DisplayStudentDB()
        {
            using (var context = new ClassroomDbContext())
            {
                int StudsCount = context.Students.Count();
                if (StudsCount == 0)
                {
                    Console.WriteLine("Database is empty. Please add new data.\nPress any key to continue");
                    Environment.Exit(0);
                }

                Console.WriteLine($"Welcome to our C# class. Which student would you like to learn more about? (enter a number 1 - {StudsCount + 1})");
                int idProvided = InputValidation.IntIsValidated();

                //Storing the values here
                string studentName = "";
                string hometown = "";
                string faveFood = "";

                var sts = context.Students.Where(s => s.StudentId == idProvided).ToList();
                foreach (var data in sts)
                {
                    //Console.WriteLine($"{ data.Name } is from { data.Hometown }. Her/His favorite food is { data.Food }");
                    studentName = data.Name;
                    hometown = data.Hometown;
                    faveFood = data.Food;
                }
                string choose = @"(Enter “Hometown” or “Favorite food”)";
                Console.WriteLine($"Student { idProvided } is { studentName }. What would you like to know about { studentName }. \n{choose}");

                while (true)
                {
                    string learnMore = Console.ReadLine().Trim().ToLower();
                    if (learnMore == "hometown")
                    {
                        Console.WriteLine($"{ studentName } is from { hometown }.");
                        Console.WriteLine($"Do you want to know more about { studentName }");
                        if (learnMore == "y")
                        {
                            Console.WriteLine($"{ studentName }'s favorite food is { faveFood }");
                            break;
                        }
                        else
                        {
                            break;
                        }

                    }
                    else if (learnMore == "food" || learnMore == "Favorite food")
                    {
                        Console.WriteLine($"{ studentName }'s favorite food is { faveFood }");
                        Console.WriteLine($"Do you want to know more about { studentName }");
                        if (learnMore == "y")
                        {
                            Console.WriteLine($"{ studentName } is from { hometown }.");
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"You made an invalid selection. {choose}");
                    }
                }
            }
        }
        static void DisplayAllDB()
        {
            using (var context = new ClassroomDbContext())
            {
                var sts = context.Students.Where(s => s.Name == s.Name).ToList();

                foreach (Student studs in sts)
                {
                    Console.WriteLine($"Id: { studs.StudentId } \tName: { studs.Name }");
                }
            }
        }
        static void CreateDb()
        {
            using (var context = new ClassroomDbContext())
            {
                Student st = new Student()
                {
                    Name = "Sean",
                    Food = "Pizza",
                    Hometown = "Plymouth"
                };

                Student st1 = new Student()
                {
                    Name = "Justin",
                    Food = "Sushi",
                    Hometown = "Wyoming"

                };

                Student st2 = new Student()
                {
                    Name = "Alice",
                    Food = "Sushi",
                    Hometown = "Detroit"

                };

                Student st3 = new Student()
                {
                    Name = "Kalai",
                    Food = "Baja Blast",
                    Hometown = "Troy"

                };

                Student st4 = new Student()
                {
                    Name = "Jason",
                    Food = "Mac and Cheese",
                    Hometown = "Courtright"

                };

                Student st5 = new Student()
                {
                    Name = "Kristen",
                    Food = "Mac & Cheese",
                    Hometown = "Orange Park"

                };

                Student st6 = new Student()
                {
                    Name = "Kamesha",
                    Food = "Tacos",
                    Hometown = "Detroit"

                };
                context.Students.Add(st);
                context.Students.Add(st1);
                context.Students.Add(st2);
                context.Students.Add(st3);
                context.Students.Add(st4);
                context.SaveChanges();
            }
        }
    }

    class InputValidation
    {
        static bool IsNum(string num)
        {
            return int.TryParse(num, out _); // Returns true if is a number
        }
        static string stringValidated()
        {
            string str;
            while (true)
            {
                str = Console.ReadLine();
                if (str == "y")
                {
                    Console.Clear();
                    break;
                }
                else if (str == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please choose y/n:");
                }
            }
            return str;
        }
        public static int IntIsValidated()
        {
            using (var context = new ClassroomDbContext())
            {
                int num;
                int StudsCount = context.Students.Count() + 1;
                string message = $"Choose a number between 1 and {StudsCount + 1}";
                int count = 0;
                while (true)
                {
                    try
                    {
                        num = int.Parse(Console.ReadLine());
                        if (num < 1)
                        {
                            count++;
                            throw new Exception($"Value entered is less than 1. \n{ message }.");
                        }
                        else if (num > StudsCount)
                        {
                            count++;
                            throw new Exception($"That student does not exist. \n{ message }.");
                        }
                        else
                        {
                            count++;
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        count++;
                        Console.WriteLine("Invalid entry. \nPlease try again: ");
                    }
                    catch (Exception error)
                    {
                        count++;
                        Console.WriteLine(error.Message);
                    }
                }
                //ConsoleCleared(count);
                return num;
            }
        }

        public static void ConsoleCleared(int count)
        {
            Console.SetCursorPosition(0, Console.CursorTop - count); // Look into how many lines can cleared
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - count);
        }
    }
}
