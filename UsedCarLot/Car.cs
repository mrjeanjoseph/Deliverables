using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    class Car
    {
        //fields
        private string _make;
        private string _model;
        private int _year;
        private decimal _price;

        //properties
        public string Make
        {
            get { return this._make; }
            set { this._make = value; }
        }
        public string Model
        {
            get { return this._model; }
            set { this._model = value; }
        }
        public int Year
        {
            get { return this._year; }
            set { this._year = value; }
        }
        public decimal Price
        {
            get { return this._price; }
            set { this._price = value; }
        }

        //no-arguments constructor
        public Car()
        {
            this._make = "";
            this._model = "";
            this._year = 0;
            this._price = 0m;
        }

        //constructor
        public Car(string make, string model, int year,  decimal price)
        {
            this._make = make;
            this._model = model;
            this._year = year;
            this._price = price;
        }

        //method
        //overridden
        public override string ToString()
        {
            string formattedList = string.Format("{0, -15} {1, -16} {2, -16} {3, -16}", this._make, this._model, this._year, this._price) ;
            
            return formattedList;
        }

    }
}
