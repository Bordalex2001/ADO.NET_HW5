using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_HW5
{
    internal class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public long Population { get; set; }
        public double Area { get; set; }
        public string Continent { get; set; }

        public Country(string name, string capital, long population, double area, string continent)
        {
            Name = name;
            Capital = capital;
            Population = population;
            Area = area;
            Continent = continent;
        }

        public override string ToString()
        {
            return $"{Name}\nCapital: {Capital}\nPopulation: {Population}\nArea: {Area}\nContinent: {Continent}";
        }
    }
}
