using System.Collections.Generic;

namespace ConsoleUI
{
    class CountryController
    {
        //Fields
        private List<Country> _countryDb = new List<Country>
        {
            new Country("USA", "North America", new List<string>{"red", "white", "blue"}),
        };

        //Property
        public List<Country> CountryDb
        {
            get { return this._countryDb; }
            set { this._countryDb = value; }
        }

        public void CountryAction(Country c)
        {
            CountryView countryView = new CountryView(c);
            countryView.Display();
        }

        public void WelcomeAction()
        {

        }
    }

}
