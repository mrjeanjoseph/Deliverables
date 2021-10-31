namespace CoffeeAndTea
{
    class PaymentType
    {

        private string _name;
        private decimal _payment;
        private string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        private decimal Payment
        {
            get { return this._payment;  }
            set { this._payment = value; }
        }

        public PaymentType(string name, decimal payment)
        {
            this._name = name;
            this._payment = payment;
        }

        public PaymentType()
        {
            this._name = "Not Applicable";
            this._payment = 0;
        }

        public override string ToString()
        {
            return $"${ this._payment }";
        }
    }

    // This class is by default CASH payment

}
