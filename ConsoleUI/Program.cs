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
            Console.WriteLine("Enter staff name, address, school and pay (Separate entries by comma)");
            //userInput = Console.ReadLine().Split(" ");
            while (true) // Validating user entries
            {
                string[] userInput; // I had to use array.
                try
                {
                    userInput = Console.ReadLine().Split(", ");
                    AddToPersonList(userInput);
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid entries. Remember to Separate each entries by a comma.");
                }
            }
            Console.ReadLine();
        }

        static void ListOfPersonsCreated()
        {
            //Initializing a list of Person
            List<Person> coolPeople = new List<Person>()
            {
                new Staff("Justin", "5511 staffing blvd", "Grand Circus", 350000),
                new Staff("Kristen", "5511 staffing blvd", "Grand Circus", 340000),
                new Student("Sean", "9957 student way", "C# DotNET", 2021, 10000),
                new Student("Kalai", "9957 student way", "C# DotNET", 2021, 10000),
                new Student("Alice", "9957 student way", "C# DotNET", 2021, 10000),
                new Student("Jason", "9957 student way", "C# DotNET", 2021, 10000)
            };

            Console.WriteLine($"A list of the { coolPeople.Count } coolest people in the CG C#DotNet class.");
            foreach (Person person in coolPeople) // printing that list
            {
                Console.WriteLine(person);
                Console.WriteLine();
            }
        }

        static void AddToPersonList(string[] userInput)
        { // I could not find a way to split my List as user input the info
          // I pass an array as parameter

            List<Person> personList = new List<Person>()
            {
                new Staff(userInput[0], userInput[1], userInput[2], double.Parse(userInput[3])) // I grabbed each one by index location
            };
            foreach (Person person in personList)
            {
                Console.WriteLine(person); // printing the list.
            }
        }
    }
}
