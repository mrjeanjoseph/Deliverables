namespace ConsoleUI
{
    class Staff : Person
    {
        //fields
        private string _school;
        private double _pay;

        //properties
        private string School
        {
            get { return _school; }
            set { _school = value; }
        }
        private double Pay
        {
            get { return _pay; }
            set { _pay = value; }
        }

        //constructor
        public Staff(string name, string address, string school, double pay) :base (name, address)
        {
            this._school = school;
            this._pay = pay;
        }

        public Staff()
        {

        }

        //Overide Methods
        public override string ToString()
        {
            string output = base.ToString();
            return $"{ output }, School: { this._school }, Pay: { this._pay }";
        }

    }

}
