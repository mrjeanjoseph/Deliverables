using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAndTea
{
    class ShoppingCart
    {
        private List<Drinks> _product = new List<Drinks>
        {
            new Drinks("Coffee","Latte",2.50M,"Light & Smooth"),
            new Drinks("Coffee","Cappucino",3.0M,"Nice & Bold"),
            new Drinks("Coffee","Espresso",5.5m,"Morning Burst"),
            new Drinks("Coffee","Cold brew",2.00m,"Simple & Rustic"),
            new Drinks("Coffee","Mocha",3.50M,"Warm & Comfy"),
            new Drinks("Coffee","Decaf",2.50M,"For Fun"),
            new Drinks("Tea","Bubble",4.50M,"Happy Day"),
            new Drinks("Tea","Green",3.50M,"Energy for Days"),
            new Drinks("Tea","Black",3.00M,"Wide Awake"),
            new Drinks("Tea","Ginger",3.5m,"Tummy Love"),
            new Drinks("Tea","Sleepy",4.00m,"Sweet Dreams"),
            new Drinks("Tea","Lemon",2.50m,"Citrus Treat")
        };

        List<Drinks> items = new List<Drinks>();
        public List<Drinks> Product
        {
            get { return this._product; }
            set { this._product = value; }
        }

        public ShoppingCart()
        {

        }

        public void ListProducts()
        {
            int counter = 1;
            foreach (Drinks products in this._product)
            {
                Console.WriteLine($"{counter}. {products.ToString()}");
                counter++;
            }
        }
    }
}
