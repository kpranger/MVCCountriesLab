using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class Country
    {
        //properties
        public string Name { set; get; }
        public string Continent { set; get; }
        //constructor
        public List<string> Colors { set; get; }
        public Country(string _name, string _continent, List<string> _colors)
        {
            Name = _name;
            Continent = _continent;
            Colors = _colors;
        }
    }
}