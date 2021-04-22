using System;
using System.Collections.Generic;

namespace UsedCarLot
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("I am some changes");
            Console.WriteLine("Jean made some changes");

            List<Car> cars = new List<Car>
            {
                new Car("Nikolai","Model s",2017,54999.90),
                new Car("Fourd","Escapade",2017,31999),
                new Car("Hyonda","Prior",2015,14795),
                new Used("GC","Chirpus",2013,8500,12345),
                new Used("GC","Witherell",2016,14450,3500.3)
            };
            Console.WriteLine("Welcome to the Grand Circus Car Emporium");
            Console.WriteLine();
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
            
            //Car car = new Car("Honda", "Civic", 2021, 24900);
            //Console.WriteLine(car.ToString());
            //Used used = new Used("Mazda", "Miata", 1995, 7000, 84950.5);
            //Console.WriteLine(used.ToString());
            
        }
    }
}



