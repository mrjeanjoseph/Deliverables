using System;

namespace JoiningDataOOP
{
    class Order
    {
        //fields
        private string _customerName;
        private string _item;
        private decimal _price;
        private int _quantity;

        //properties
        public int Quantity
        {
            get { return this._quantity; }
            set { this._quantity = value; }
        }
        public decimal Price
        {
            get { return this._price; }
            set { this._price = value; }
        }
        public string Item
        {
            get { return this._item; }
            set { this._item = value; }
        }
        public string CustomerName
        {
            get { return this._customerName; }
            set { this._customerName = value; }
        }

        public Order(string customerName, string item, decimal price, int quantity)
        {
            this._customerName = customerName;
            this._item = item;
            this._price = price;
            this._quantity = quantity;
        }

        public override string ToString()
        {
            //decimal total = 
            return string.Format("\t{0, -20} {1, -20} {2, 0}", this._item, this._price, this._quantity);
            //return string.Format("\t{0, -20} {1, -20} {2, -20} {3, 0}", this.CustomerName, this._item, this._price, this._quantity);
        }
    }
}
