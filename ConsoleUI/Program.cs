using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Johnson", "5511 main street");
            string result = person.ToString();

            Console.WriteLine(result);
        }
    }

}
