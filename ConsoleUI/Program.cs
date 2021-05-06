using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Jimmy", 13),
                new Student("Hannah Banana", 21),
                new Student("Justin", 30),
                new Student("Sarah", 53),
                new Student("Hannibal", 15),
                new Student("Phillip", 16),
                new Student("Maria", 63),
                new Student("Abe", 33),
                new Student("Obe", 33),
                new Student("Curtis", 10)
            };

            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            //NumCollections(nums);
            StudentCollections(students);
            Console.ReadLine();
        }

        static void NumCollections(int[] nums)
        {
            //1. Find the Minimum value
            int minValue = nums.Min(value => value);
            Console.WriteLine($"Minimum value: {minValue}\n");

            //2. Find the Maximum value
            int MaxValue = nums.Max(value => value);
            Console.WriteLine($"Maximum value: {MaxValue}\n");

            //3. Find the Maximum value less than 10000
            MaxValue = nums.Where(value => value < 10000).Max(value => value);
            Console.WriteLine($"Max value greater than 10000: {MaxValue}\n");

            //4. Find all the values between 10 and 100
            var valuesBetween = from vb in nums
                                where vb >= 10 && vb <= 100
                                select vb;
            Console.Write("Value between 10 & 100: ");
            foreach (int vb in valuesBetween)
            {
                Console.Write($"{vb}, ");
            }

            //5. Find all the Values between 100000 and 999999 inclusive
            valuesBetween = from vb in nums
                            where vb >= 100000 && vb <= 999999
                            select vb;
            Console.Write($"\n\nValue between 100000 & 999999: ");
            foreach (var vb in valuesBetween)
            {
                Console.Write($"{vb}");
            }

            //6. Count all the even numbers
            int evenNums = nums.Count(e => e % 2 == 0);
            Console.WriteLine($"\n\nEven Numbers: {evenNums}\n");
        }
        static void StudentCollections(List<Student> allStudents)
        {
            //1. Find all students age of 21 and over (aka US drinking age)
            List<Student> drinkingAge = allStudents.Where(da => da.Age >= 21).ToList();
            Console.WriteLine("These students can drink");
            foreach (Student da in drinkingAge)
            {
                Console.WriteLine(da.Name);

            }

            //2. Find the oldest student
            var oldestSutdent = allStudents.OrderByDescending(stud => stud.Age).ToList();
            Console.WriteLine($"\n{ oldestSutdent[0].Name } is oldest at { oldestSutdent[0].Age }");

            // This option only print their age
            //int oldestSutdent = allStudents.Max(os => os.Age);
            //Console.WriteLine($"The oldest student is {oldestSutdent }");

            //3. Find the youngest student
            var youngestSutdent = allStudents.OrderBy(stud => stud.Age).ToList();
            Console.WriteLine($"\n{ youngestSutdent[0].Name } is Youngest at { youngestSutdent[0].Age }");

            // This option only print age
            //int youngestSutdent = allStudents.Min(os => os.Age);
            //Console.WriteLine($"The youngest student is {youngestSutdent}");

            //4. Find the oldest student under the age of 25
            var oldestUnder25 = allStudents.Where(stud => stud.Age <= 25).ToList();
            Console.WriteLine($"\n{ oldestUnder25[0].Name } is oldest under 25 at { oldestUnder25[0].Age }."); // there's an error here / use the querie

            //5. Find all students over 21 and with even ages
            Console.WriteLine("\nThese students are over 21 with even ages:");
            List<Student> Over21AndEvenAges = (from over21 in allStudents
                                                           where over21.Age >= 21
                                                           && over21.Age % 2 == 0
                                                           select over21).ToList();
            foreach (Student over21 in Over21AndEvenAges)
            {
                Console.WriteLine($"\t{ over21.Name } is { over21.Age } years old");
            }

            //6. Find all teenage students (13 to 19 inclusive)
            Console.WriteLine("\nThese are teenage students:");
            List<Student> teenAgers = (from ta in allStudents
                                               where ta.Age >= 13
                                               && ta.Age <= 19
                                               select ta).ToList();
            foreach (Student ta in teenAgers)
            {
                Console.WriteLine($"\t{ ta.Name } is { ta.Age } years old");
            }

            //7. Find all students whose name starts with a vowel. - INCOMPLETE
            Console.WriteLine("\nAll students whose name starts with a vowel:");
            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            var startsWithVowels = (from swv in allStudents
                                    where swv.Name.ToLower().StartsWith('a')
                                    || swv.Name.ToLower().StartsWith('e')
                                    || swv.Name.ToLower().StartsWith('i')
                                    || swv.Name.ToLower().StartsWith('o')
                                    || swv.Name.ToLower().StartsWith('u')
                                    select swv);
            //List<Student> startsWithVowels = allStudents.Where(swv => swv.Name.ToLower().StartsWith('a')).ToList();
            foreach (Student studs in startsWithVowels)
            {
                Console.WriteLine(studs.Name);
            }
            Console.WriteLine("I am here");
        }
    }
}
