namespace ConsoleUI
{
    class Person
    {
        //fields
        private string _name;
        private string _address;

        //properties
        private string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        private string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        //constructor
        public Person(string name, string address)
        {
            this._name = name;
            this._address = address;
        }

        public Person()
        {

        }

        //Method
        public override string ToString()
        {
            return $"Name: { this._name } \nAdress: { this._address }";
        }
    }
}
