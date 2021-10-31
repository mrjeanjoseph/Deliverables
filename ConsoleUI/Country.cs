using System.Collections.Generic;

namespace ConsoleUI
{
    class Country
    {
        private string _name;
        private string _continent;
        private List<string> _colors;

        public List<string> Colors
        {
            get { return this._colors; }
            set { this._colors = value; }
        }
        public string Continent
        {
            get { return this._continent; }
            set { this._continent = value; }
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public Country(string name, string continent, List<string> colors)
        {
            this._name = name;
            this._continent = continent;
            this._colors = colors;
        }
    }

}
