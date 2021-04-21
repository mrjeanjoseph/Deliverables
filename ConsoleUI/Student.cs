namespace ConsoleUI
{
    class Student : Person
    {
        //fields
        private string _program;
        private int _year;
        private double _fee;

        //properties
        private string Program
        {
            get { return _program; }
            set { _program = value; }
        }
        private int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        private double Fee
        {
            get { return _fee; }
            set { _fee = value; }
        }

        //constructor
        public Student(string name, string address, string program, int year, double fee) : base (name, address)
        {
            this._program = program;
            this._year = year;
            this._fee = fee;
        }

        public Student()
        {

        }

        //Method
        public override string ToString()
        {
            string output = base.ToString();
            return $"{ nameof(Student) } { output }, \nProgram: { this._program }, \nYear: { this._year }, \nFee: { this._fee }";
        }
    }
}
