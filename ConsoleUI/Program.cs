using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> coolPeople = new List<Person>()
            {
                new Staff("Justin", "5511 staffing blvd", "Grand Circus", 150000),
                new Staff("Kristen", "5511 staffing blvd", "Grand Circus", 150000),
                new Student("Sean", "9957 student way", "C# .NET", 2021, 10000),
                new Student("Kalai", "9957 student way", "C# .NET", 2021, 10000),
                new Student("Jason", "9957 student way", "C# .NET", 2021, 10000)             
            };

            Console.WriteLine($"This is a list of cool people in the C#DotNet class. About { coolPeople.Count }");
            foreach (Person person in coolPeople)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("=====================================");
            AddPerson();
            Console.ReadLine();
        }

        static void AddPerson()
        {
            string userInput = Console.ReadLine();
            List<Person> personList = new List<Person>()
            {
                new Staff(userInput, userInput, userInput, int.Parse(userInput))
            };
            foreach (Person person in personList)
            {
                Console.WriteLine(person);
            }
        }
    }
}
