using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    class Used : Car
    {
        //fields
        private double _mileage;

        //properties
        public double Mileage
        {
            get { return this._mileage; }
            set { this._mileage = value; }
        }

        //no arguments constructor
        public Used() : base()
        {
            this._mileage = 0;
        }

        //constructor
        public Used(string make, string model, int year, decimal price, double mileage) : base (make, model, year, price)
        {
            this._mileage = mileage;
        }

        //method
        //overridden
        public override string ToString()
        {
            string result = base.ToString();
            return $"{result} \t(Used) {this._mileage} miles";// return base.ToString()+${this._mileage}
        }
    }
}
