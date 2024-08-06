using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_HW5
{
    internal class Program
    {
        static void Main()
        {
            List<Country> countries = new List<Country>
            {
                new Country("Ukraine", "Kyiv", 36700000, 603600, "Europe"),
                new Country("Kazakhstan", "Astana", 20118000, 2725000, "Asia"),
                new Country("Egypt", "Cairo", 105914000, 1001000, "Africa"),
                new Country("Brazil", "Brazilia", 203081000, 8510000, "South America"),
                new Country("The USA", "Washington", 335893000, 9525000, "North America"),
                new Country("Australia", "Canberra", 27365000, 7741000, "Australia"),
                new Country("Czech Republic", "Prague", 10860000, 79000, "Europe"),
                new Country("Japan", "Tokyo", 123960000, 378000, "Asia"),
                new Country("Tanzania", "Dodoma", 65070000, 947000, "Africa"),
                new Country("Argentina", "Buenos Aires", 47067000, 2780000, "South America"),
                new Country("Canada", "Ottawa", 41013000, 9985000, "North America"),
                new Country("The UK", "London", 67596000, 244000, "Europe"),
                new Country("Turkey", "Ankara", 85372000, 784000, "Asia"),
                new Country("Colombia", "Bogota", 52696000, 1139000, "South America"),
                new Country("Mexico", "Mexico", 129714000, 1964000, "North America"),
                new Country("Greece", "Athens", 10414000, 132000, "Europe"),
                new Country("Malaysia", "Kuala Lumpur", 33981000, 330000, "Asia"),
                new Country("South Africa", "Pretoria", 63016000, 1219000, "Africa"),
                new Country("Finland", "Helsinki", 5583000, 338000, "Europe"),
                new Country("Netherlands", "Amsterdam", 17978000, 42000, "Europe"),
            };

            var allCountries = countries.Select(c => c);
            Console.WriteLine("Всі країни:");
            Console.WriteLine("{0, -20} {1, -20} {2, -15} {3, -15} {4, -20}", "Country", "Capital", "Population", "Area", "Continent");
            Console.WriteLine(new string('-', 87));
            foreach (var country in allCountries)
            {
                Console.WriteLine("{0, -20} {1, -20} {2, -15} {3, -15} {4, -20}", country.Name, country.Capital, country.Population, country.Area, country.Continent);
            }

            var countryNames = countries.Select(c => c.Name);
            Console.Write("\nНазви країн: ");
            foreach (var name in countryNames)
            {
                Console.Write(name + ", ");
            }
            Console.WriteLine();

            var capitalNames = countries.Select(c => c.Capital);
            Console.Write("\nНазви столиць: ");
            foreach (var capital in capitalNames)
            {
                Console.Write(capital + ", ");
            }
            Console.WriteLine();

            var europeanCountries = countries
                .Where(c => c.Continent == "Europe")
                .Select(c => c.Name);
            Console.Write("\nНазви країн Європи: ");
            foreach (var country in europeanCountries)
            {
                Console.Write(country + ", ");
            }
            Console.WriteLine();

            double specificArea = 1000000;
            var countryAreaLargerThan = countries
                .Where(c => c.Area > specificArea)
                .Select(c => c.Name);
            Console.Write($"\nКраїни, у яких площа сягає більше ніж {specificArea}: ");
            foreach (var country in countryAreaLargerThan)
            {
                Console.Write(country + ", ");
            }
            Console.WriteLine();

            var countiesWithAAndU = countries
                .Where(c => c.Name.ToLower().Contains('a') 
                && c.Name.ToLower().Contains('u'))
                .Select(c => c.Name) ;
            Console.Write("\nКраїни, у яких назви мають літери A та U: ");
            foreach (var country in countiesWithAAndU)
            {
                Console.Write(country + ", ");
            }
            Console.WriteLine();

            var countiesWithFirstA = countries
                .Where(c => c.Name.StartsWith("A"))
                .Select(c => c.Name);
            Console.Write("\nКраїни, у яких назви починаються з літери A: ");
            foreach (var country in countiesWithFirstA)
            {
                Console.Write(country + ", ");
            }
            Console.WriteLine();

            double minSpecificArea = 500000;
            double maxSpecificArea = 5000000;
            var countryAreaByRange = countries
                .Where(c => c.Area >= minSpecificArea 
                && c.Area <= maxSpecificArea)
                .Select(c => c.Name);
            Console.Write($"\nКраїни, у яких площа сягає від {minSpecificArea} до {maxSpecificArea}: ");
            foreach (var country in countryAreaByRange)
            {
                Console.Write(country + ", ");
            }
            Console.WriteLine();

            long specificPopulation = 50000000;
            var countryPopulationLargerThan = countries
                .Where(c => c.Population > specificPopulation)
                .Select(c => c.Name);
            Console.Write($"\nКраїни, у яких населення сягає більше ніж {specificPopulation}: ");
            foreach (var country in countryPopulationLargerThan)
            {
                Console.Write(country + ", ");
            }
            Console.WriteLine();

            var top5CountriesByArea = countries
                .OrderByDescending(c => c.Area)
                .Take(5);
            Console.Write($"\nПерші п'ять країн за площею: ");
            Console.WriteLine("\n{0, -20} {1, -20} {2, -15} {3, -15} {4, -20}", "Country", "Capital", "Population", "Area", "Continent");
            Console.WriteLine(new string('-', 87));
            foreach (var country in top5CountriesByArea)
            {
                Console.WriteLine("{0, -20} {1, -20} {2, -15} {3, -15} {4, -20}", country.Name, country.Capital, country.Population, country.Area, country.Continent);
            }
            Console.WriteLine();

            var top5CountriesByPopulation = countries
                .OrderByDescending(c => c.Population)
                .Take(5);
            Console.Write($"\nПерші п'ять країн за населенням: ");
            Console.WriteLine("\n{0, -20} {1, -20} {2, -15} {3, -15} {4, -20}", "Country", "Capital", "Population", "Area", "Continent");
            Console.WriteLine(new string('-', 87));
            foreach (var country in top5CountriesByPopulation)
            {
                Console.WriteLine("{0, -20} {1, -20} {2, -15} {3, -15} {4, -20}", country.Name, country.Capital, country.Population, country.Area, country.Continent);
            }
            Console.WriteLine();

            var largestAreaCountry = countries
                .OrderByDescending(c => c.Area)
                .First().Name;
            Console.Write($"\nКраїна з найбільшою площею: {largestAreaCountry}");
            Console.WriteLine();

            var largestPopulationCountry = countries
                .OrderByDescending(c => c.Population)
                .First().Name;
            Console.Write($"\nКраїна з найбільшим населенням: {largestPopulationCountry}");
            Console.WriteLine();

            var smallestAreaCountryOfAfrica = countries
                .Where(c => c.Continent == "Africa")
                .OrderByDescending(c => c.Area)
                .Last().Name;
            Console.Write($"\nКраїна Африки з найменшою площею: {smallestAreaCountryOfAfrica}");
            Console.WriteLine();

            var averageAreaOfAsianCountries = (from c in countries
                                           where c.Continent == "Asia"
                                           select c.Area)
                                           .Average();
            Console.Write($"\nСередня площа країн Азії: {averageAreaOfAsianCountries}");
            Console.WriteLine();
        }
    }
}
