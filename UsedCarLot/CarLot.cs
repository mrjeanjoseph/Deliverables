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
        public List<Car> MyProperty
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
            Restock();
        }

        public string GreetingClients()
        {
            return $"Welcome to { this._name.ToUpper() }";
        }

        private void Restock()
        {
            List<Car> cars = new List<Car>
            {
                new Car("Nikolai","Model S",2017,54999.90),
                new Car("Fourd","Escapade",2017,31999.90),
                new Car("Chewie","Vette",2017,44989.95),
                new Used("Hyonda","Prior",2015,14795.50,35987.6),
                new Used("GC","Chirpus",2013,8500,12345),
                new Used("GC","Witherell",2016,14450,3500.3),                
            };

            this._inventory = cars;
        }

        private void AddNewCars(List<Car> carInfo)
        {
            // Add a car to the list of Car via user input
            Car car = new Car(carInfo, carInfo, carInfo, carInfo);
        }

        public void AddACar(string make, string model, int year, double price)
        {
            Car car = new Car();
            AddACar(make, model, year, price);



            Car car = new Car(make, model, year, price);
            AddACar("Honda", "Civic", 2021, 24900);
            foreach (Car newcar in cars)
            {
                Console.WriteLine(newcar);
            }
        }

        public void ListAllCars()
        {
            int count = 0;
            foreach (Car cars in this._inventory)
            {
                count++;
                //Console.WriteLine($"{cars}");
                string formattedList = string.Format("{0, -15} {1, -16} {2, -16} {3, -16}", cars.Make, cars.Model, cars.Year, cars.Price, cars.ToString());
                Console.WriteLine($"{count}: {formattedList}");

            }
        }
    }
}



