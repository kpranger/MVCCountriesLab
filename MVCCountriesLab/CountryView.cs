using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class CountryView
    {
        //property
        public Country DisplayCountry { get; set; }
        //constructor
        public CountryView(Country _displayCountry)
        {
            DisplayCountry = _displayCountry;
        }
        //method
        public void Display()
        {
            Console.WriteLine($"Country Name: {DisplayCountry.Name}\n" +
                $"Continent: {DisplayCountry.Continent}\n");
            foreach (string c in DisplayCountry.Colors)
            {
                Console.WriteLine($"{DisplayCountry.Colors}");
            }
            //make foreach on display Country.colors
            //Cw each string in foreach
        }
    }
}
