namespace ConsoleUI
{
    class Student
    {
        private string _name;
        private int _age;

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public int Age
        {
            get { return this._age; }
            set { this._age = value; }
        }
        public Student(string name, int age)
        {
            this._name = name;
            this._age = age;
        }
    }
}
