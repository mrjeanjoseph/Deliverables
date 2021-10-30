
using System;

namespace ConsoleUI
{
    class Circle
    {
        //fields
        private double _radius;

        //constructor
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        public Circle(double radius) // Constructors
        {
            this._radius = FormatNumber(radius);
        }

        //Methods
        public double CalculateCircumference()
        {
            return 2 * Math.PI * _radius;             
        }

        public string CalculateFormattedCircumference()
        {
            return $"Circumference: {Math.Round(CalculateCircumference(), 2)}";
        }

        public double CalculateArea()
        {
            this._radius = Math.PI * Math.Pow(_radius, 2);
            return _radius;
        }

        public string CalculateFormattedArea()
        {
            return $"Area: {Math.Round(CalculateArea(), 2)}";
        }

        private static double FormatNumber(double x)
        {
            Console.WriteLine("Enter a radius: ");
            while (true)
            {                
                try
                {
                    x = int.Parse(Console.ReadLine());
                    if (x > 0)
                    {
                        break;
                    }
                    else
                    {
                        throw new Exception("Value entered needs to be 1 or greater");
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Value entered is not a number. \nPlease try again: ");
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            return x;
        }
    }
}
