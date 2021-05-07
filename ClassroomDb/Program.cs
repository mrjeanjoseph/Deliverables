using System;
using System.Linq;

namespace ClassroomDb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to classroom database");
            bool runAgain = true;
            while (runAgain)
            {
                DisplayAllDB();
                DisplayStudentDB();
                Console.WriteLine("Would you like to learn about another student? (y/n)");
                string userChoise = InputValidation.YesNoChoice();
                if (userChoise != "y")
                {
                    break;
                } 
            }
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
                    Console.WriteLine("Database is empty. Choose 'y' to load data");
                    string userChoise = InputValidation.YesNoChoice();
                    if (userChoise == "y")
                    {
                        CreateDb();
                    }
                }

                Console.WriteLine($"Welcome to our C# class. Which student would you like to learn more about? (enter a number 1 - {StudsCount + 1})");
                int idProvided = InputValidation.IntIsValidated();

                //Storing the values here
                string studentName = "";
                string hometown = "";
                string faveFood = "";

                //Getting student name by id
                var sts = context.Students.Where(s => s.StudentId == idProvided).ToList();
                foreach (var data in sts)
                {
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
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine($"Do you want to know more about { studentName }. (y/n)");
                        learnMore = InputValidation.YesNoChoice();
                        if (learnMore == "y")
                        {
                            Console.WriteLine($"{ studentName }'s favorite food is { faveFood }");
                            break;
                        }
                        break;
                    }
                    else if (learnMore == "food" || learnMore == "Favorite food")
                    {
                        Console.WriteLine($"{ studentName }'s favorite food is { faveFood }");
                        System.Threading.Thread.Sleep(3000);
                        Console.ReadLine();
                        Console.WriteLine($"Do you want to know more about { studentName }. (y/n)");
                        learnMore = InputValidation.YesNoChoice();
                        if (learnMore == "y")
                        {
                            Console.WriteLine($"{ studentName } is from { hometown }.");
                            break;
                        }
                        break;
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
}
