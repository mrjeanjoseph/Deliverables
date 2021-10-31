using System;
using System.Collections.Generic;

namespace UsedCarLot
{
    class CarLot
    {
        //fields
        private string _name;
        private List<Car> _inventory;

        //properties
        public List<Car> Inventory
        {
            get { return this._inventory; }
            set { this._inventory = value; }
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        //contructor
        public CarLot()
        {
            this._name = "";
        }

        public CarLot(string name)
        {
            this._name = name;
            CarDataCollection();
        }

        public string GreetingClients()
        {
            return $"Welcome to { this._name.ToUpper() }";
        }

        private void CarDataCollection()
        {
            List<Car> cars = new List<Car>
            {
                new Car("Nikolai","Model S",2017,54999.90m),
                new Car("Fourd","Escapade",2017,31999.90m),
                new Car("Chewie","Vette",2017,44989.95m),
                new Used("Hyonda","Prior",2015,14795.50m,35987.6),
                new Used("GC","Chirpus",2013,8500,12345),
                new Used("GC","Witherell",2016,14450,3500.3),
                
            };
            this._inventory = cars;
        }
        public void ViewCar(int userInput)
        {
            Console.WriteLine(Inventory[userInput - 1]);
        }

        public void AddNewCars(Car car)
        {
            
            this._inventory.Add(car);           
           
        }

        public void RemoveCar( int userInput)
        {
            
            
            this._inventory.RemoveAt(userInput-1);     

           
            

        }

        public void ListAllCars()
        {
            int count = 0;
            foreach (Car cars in this._inventory)
            {
                count++;
                Console.WriteLine($"{count}. {cars}");               

            }
            Console.WriteLine($"{count+1}.Add a car");
            Console.WriteLine($"{count + 2}.Quit");
        }
    }
}



