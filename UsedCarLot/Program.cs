using System;
using System.Collections.Generic;

namespace UsedCarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep(200, 500);
            RunProgram();         

            
            
        }

        
        static void RunProgram()
        {
            CarLot emporium = new CarLot("Grant Chirpus’ Used Car Emporium");
            Console.WriteLine(emporium.GreetingClients());
            emporium.ListAllCars();
            bool runProgram = true;
            int userInput =0;
            while (runProgram)
            {
                Console.WriteLine("Enter your choice");
                Car newCar = new Car();
                Used usedCar = new Used();
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    if(userInput <= 0 || userInput > emporium.Inventory.Count+ 2 )
                    {
                        Console.WriteLine("Not less than 0 and more than the list");
                        continue;
                    }

                }
                catch(Exception)
                {
                    Console.WriteLine("not a number");
                    continue;
                }

                if (userInput == emporium.Inventory.Count + 1)
                {
                    Console.WriteLine("Do you want to add a new car or used car?");
                    string choice = Console.ReadLine().Trim().ToLower();
                    if (choice == "new")
                    {
                        Console.WriteLine("Make of the car:");
                        newCar.Make = Console.ReadLine();
                        Console.WriteLine("Model of the car:");
                        newCar.Model = Console.ReadLine();
                        Console.WriteLine("Year of the car:");
                        newCar.Year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Price of the car:");
                        newCar.Price = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Your car has been added");
                        emporium.AddNewCars(newCar); // This will store it in the data collection
                        emporium.ListAllCars();

                    }

                    else if (choice == "used")
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
                    else
                    {
                        Console.WriteLine("Your choice is invalid");
                    }
                }

                
               
                else if (userInput == emporium.Inventory.Count + 2)
                {
                    Console.WriteLine("Good bye");
                    Environment.Exit(0);

                }
                else
                {
                    emporium.ViewCar(userInput);
                    Console.WriteLine("Do you want to buy this car?y/n");
                    string inputChoice = Console.ReadLine();
                    if (inputChoice == "y")
                    {
                        Console.WriteLine("Excellent!  Our finance department will be in touch shortly.");
                        emporium.RemoveCar(userInput);
                        emporium.ListAllCars();
                    }
                }
                while (true)
                {
                    Console.WriteLine("Do you want to continue?y/n");
                    string choice = Console.ReadLine().ToLower().Trim();
                    if (choice == "y")
                    {
                        Console.Clear();
                        emporium.ListAllCars();
                        break;
                    }
                    else if(choice == "n")
                    {
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input.Please type y/n");
                    }
                }
                
            }
        }
    }
}



