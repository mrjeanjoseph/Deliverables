namespace CoffeeAndTea
{
    class Cash : PaymentType
    {
        public Cash(string name, decimal payment) :base(name, payment)
        {
            
        }

        public override string ToString()
        {
            return base.ToString();            
        }
    }

}
