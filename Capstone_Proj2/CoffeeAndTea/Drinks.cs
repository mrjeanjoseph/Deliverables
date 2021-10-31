using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAndTea
{
    class Drinks
    {
        private string _category;
        private string _name;
        private decimal _price;
        private string _type;

        public string Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        public decimal Price
        {
            get { return this._price; }
            set { this._price = value; }
        }

        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        public Drinks(string category, string name, decimal price, string type)
        {
            this._category = category;
            this._name = name;
            this._price = price;
            this._type = type;
        }

        public Drinks()
        {

        }

        public override string ToString()
        {
            string formatDrinkList = string.Format("\t{0, -15} {1, -16} ${2, -16} {3, -10}", this._category, this._name, this._price, this._type);
            return formatDrinkList;
        }
    }
}
