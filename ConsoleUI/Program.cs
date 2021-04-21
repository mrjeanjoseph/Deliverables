using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Johnson", "5511 main street");
            string personInfo = person.ToString();
            Console.Write(personInfo);

            Student student = new Student("Jason", "5988 default blvd", "Computer Science", 2021, 799.99);
            string studentInfo = student.ToString();
            Console.Write(studentInfo);

        }
    }

}
