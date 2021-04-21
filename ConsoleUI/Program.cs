using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========Extra Excercise1============");
            ListOfPersonsCreated();

            Console.WriteLine("===========Extra Excercise2============");
            Console.WriteLine("Enter staff name, address, school and pay (make sure to separate them by comm)");
            string[] userInput = Console.ReadLine().Split(" ");
            AddToPersonList(userInput);
            Console.ReadLine();
        }

        static void ListOfPersonsCreated()
        {            
            List<Person> coolPeople = new List<Person>()
            {
                new Staff("Justin", "5511 staffing blvd", "Grand Circus", 350000),
                new Staff("Kristen", "5511 staffing blvd", "Grand Circus", 340000),
                new Student("Sean", "9957 student way", "C# .NET", 2021, 10000),
                new Student("Kalai", "9957 student way", "C# .NET", 2021, 10000),
                new Student("Jason", "9957 student way", "C# .NET", 2021, 10000)
            };

            Console.WriteLine($"This is a list of cool people in the C#DotNet class. About { coolPeople.Count }");
            foreach (Person person in coolPeople)
            {
                Console.WriteLine(person);
            }
        }

        static void AddToPersonList(string[] userInput)// I could not find a way to split my list as user input the info
        {
            List<Person> personList = new List<Person>()
            {
                new Staff(userInput[0], userInput[1], userInput[2], double.Parse(userInput[3]))
            };
            foreach (Person person in personList)
            {
                Console.WriteLine(person);
            }
        }
    }
}
