using System;

namespace UsedCarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Car Emporium");
            Console.WriteLine();
            Car car = new Car("Honda", "Civic", 2021, 24900);
            Console.WriteLine(car.ToString());
            Used used = new Used("Mazda", "Miata", 1995, 7000, 84950.5);
            Console.WriteLine(used.ToString());
        }
    }
}
