using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class CountryController
    {
        //properties
        public List<Country> CountryDb = new List<Country>()
        {
            new Country($"U.S.A.", "North America", new List<string> { "red", "white", "blue" }),
            new Country($"Germany", "Europe", new List<string> { "red", "black", "yellow" }),
            new Country($"Sweden", "Europe", new List<string> { "yellow", "blue" }),
            new Country($"Mexico", "North America", new List<string> { "green", "while", "red" }),
        };

    //constructors
    public CountryController()
        {

        }

        //methods
        public void CountryAction(Country c)
        {

        }
        public void WelcomeAction()
        {
            //pass CountryDb into the CountryListView class
            Console.WriteLine($"Hello, welcome to the country app. Please select a country from " +
                $"the following list by their number:");
            foreach (Country x in CountryDb)
            {
                CountryListView country = new CountryListView(x);
                country.Display();
            }
        }

    }
}