using System;
using System.Linq;

namespace ClassroomDb
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("YOUR INFO:");
            //CreateDb();
            DisplayAllDB();
            DisplayStudentDB();

            Console.ReadLine();
        }

        private static void DisplayStudentDB()
        {
            using (var context = new ClassroomDbContext())
            {
                if (context.Students.Count() == 0)
                {
                    Console.WriteLine("Empty");
                }
                Console.WriteLine("Search for an Id");
                int id = int.Parse(Console.ReadLine());
                //Student s = new Student
                //{
                //    StudentId = id
                //};
                var sts = context.Students.Where(s => s.StudentId == id).ToList();

                foreach (var data in sts)
                {
                    Console.WriteLine($"{ data.Name } is from { data.Hometown }. Her/His favorite food is { data.Food }");
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
