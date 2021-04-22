using System;
using System.Collections.Generic;

namespace UsedCarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            //JeanTestsCodesForNow(); // This is calling the method below
            CodesFromMain();
            Console.ReadLine();
        }

        static void JeanTestsCodesForNow()
        {
            CarLot emporium = new CarLot("Grant Chirpus’ Used Car Emporium");
            Console.WriteLine(emporium.GreetingClients());
            emporium.ListAllCars();
        }

        static void CodesFromMain()
        {

            List<Car> cars = new List<Car> // I moved all of this code to the "CarLot" class under ListAll cars method
            {
                new Car("Nikolai","Model s",2017,54999.90),
                new Car("Fourd","Escapade",2017,31999),
                new Car("Hyonda","Prior",2015,14795),
                new Used("GC","Chirpus",2013,8500,12345),
                new Used("GC","Witherell",2016,14450,3500.3)
            };
            Console.WriteLine("Welcome to the Grand Circus Car Emporium");
            Console.WriteLine();
            foreach (Car car in cars) // I moved all of this code to the "CarLot" class under display method
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("Add a car : need to work");

            //Car car = new Car("Honda", "Civic", 2021, 24900);
            //Console.WriteLine(car.ToString());
            //Used used = new Used("Mazda", "Miata", 1995, 7000, 84950.5);
            //Console.WriteLine(used.ToString());
        } // Codes to be modified
    }
}



