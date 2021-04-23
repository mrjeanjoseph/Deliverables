using System;
using System.Collections.Generic;

namespace UsedCarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep(200, 500);
            JeanTestsCodesForNow(); // This is calling the method below
            //CodesFromMain();
            //Console.ReadLine();

            CarLot emporium = new CarLot("Grant Chirpus’ Used Car Emporium");
            //Console.WriteLine("Add a new car?: choose (new/used)");
            //Used usedCar = new Used();
            //usedCar.Make = Console.ReadLine();

        }

        //static void Choice(int userInput) 
        //{
        //    List<Car> car = new List<Car>();
        //    if (userInput > car.Count)
        //    {
        //        Console.WriteLine($"Number entered is invalid");
        //    }
        //    else if (userInput == car.Count -1)
        //    {
        //        Console.WriteLine("Goodbye");
        //    }
        //    else if (userInput == 5)
        //    {
        //        Console.WriteLine("I am here");
        //    }
        //}

        static void JeanTestsCodesForNow()
        {
            CarLot emporium = new CarLot("Grant Chirpus’ Used Car Emporium");
            Console.WriteLine(emporium.GreetingClients());
            emporium.ListAllCars();           

            Console.WriteLine("Enter your choice");
            Car newCar = new Car();
            Used usedCar = new Used();
            int userInput = int.Parse(Console.ReadLine());
            
            if (userInput == emporium.Inventory.Count +1)
            {
                Console.WriteLine("Do you want to add a new car or used car?");
                string choice = Console.ReadLine();
                if(choice == "new")
                {
                    Console.WriteLine("Make of the car:");
                    newCar.Make = Console.ReadLine();
                    Console.WriteLine("Model of the car:");
                    newCar.Model = Console.ReadLine();
                    Console.WriteLine("Year of the car:");
                    newCar.Year = int.Parse(Console.ReadLine());
                    Console.WriteLine("Price of the car:");
                    newCar.Price = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Your car have been added");
                    emporium.AddNewCars(newCar); // This will store it in the data collection
                    emporium.ListAllCars();

                }

                else if(choice == "used")
                {
                    Console.WriteLine("Make of the car:");
                    usedCar.Make = Console.ReadLine();
                    Console.WriteLine("Model of the car:");
                    usedCar.Model = Console.ReadLine();
                    Console.WriteLine("Year of the car:");
                    usedCar.Year = int.Parse(Console.ReadLine());
                    Console.WriteLine("Price of the car:");
                    usedCar.Price = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Milleage of the car:");
                    usedCar.Mileage = double.Parse(Console.ReadLine());

                    emporium.AddNewCars(usedCar); // This will store it in the data collection
                    emporium.ListAllCars();
                }
            }
            
            // Console.Clear();
            //Console.WriteLine("Your car have been added");
            else if(userInput == emporium.Inventory.Count + 2)
            {
                Console.WriteLine("Good bye");
                
            }
            else
            {
                emporium.ViewCar(userInput);
                Console.WriteLine("Do you want to buy this car?y/n");
                string inputChoice = Console.ReadLine();
                if (inputChoice == "y")
                {
                    emporium.RemoveCar(userInput);
                    emporium.ListAllCars();
                }
            }
                
            //}

            //static void CodesFromMain()
            //{

            //    List<Car> cars = new List<Car> // I moved all of this code to the "CarLot" class under ListAll cars method
            //    {
            //        new Car("Nikolai","Model s",2017,54999.90m),
            //        new Car("Fourd","Escapade",2017,31999),
            //        new Car("Hyonda","Prior",2015,14795),
            //        new Used("GC","Chirpus",2013,8500,12345),
            //        new Used("GC","Witherell",2016,14450,3500.3)
            //    };
            //    Console.WriteLine("Welcome to the Grand Circus Car Emporium");
            //    Console.WriteLine();
            //    foreach (Car car in cars) // I moved all of this code to the "CarLot" class under display method
            //    {
            //        Console.WriteLine(car);
            //    }

            //    Console.WriteLine("Add a car : need to work");

            //    //Car car = new Car("Honda", "Civic", 2021, 24900);
            //    //Console.WriteLine(car.ToString());
            //    //Used used = new Used("Mazda", "Miata", 1995, 7000, 84950.5);
            //    //Console.WriteLine(used.ToString());
            //} // Codes to be modified
        }
    }
}



