using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301264350_shields__Lab4_Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 01 - Lab 04");

            // Sarah Shields 301264350 Sec 403

            // Invokes methods
            Question1_1();
            Question1_2();
            Question1_3();
            Question1_4();
            Question1_5();
            Question1_6();


            // 1.1 List the names of the countries in alphabetical order [0.5 mark]
            void Question1_1()
            {
                var countries = Country.GetCountries();
                var countryNamesAlphabetical = countries.OrderBy(country => country.Name).Select(country => country.Name);
                Console.WriteLine("The countries in alphabetical order are:");
                foreach (var name in countryNamesAlphabetical)
                {
                    Console.WriteLine(name);
                }
            }

            // 1.2 List the names of the countries in descending order of number of resources [0.5 mark]
            void Question1_2()
            {
                var countries = Country.GetCountries();
                var countryNamesDescendingResources = countries.OrderByDescending(country => country.Resources.Count).Select(country => country.Name);
                Console.WriteLine("\nThe countries by descending order of number of resources are:");
                foreach (var name in countryNamesDescendingResources)
                {
                    Console.WriteLine(name);
                }
            }

            // 1.3 List the names of the countries that shares a border with Argentina [0.5 mark]
            void Question1_3()
            {
                var countries = Country.GetCountries();
                var argentinaBorders = countries.First(country => country.Name == "Argentina").Borders;
                var countriesBorderingArgentina = countries.Where(country => argentinaBorders.Contains(country.Name)).Select(country => country.Name);
                Console.WriteLine("\nThe countries that share a border with Argentina are:");
                foreach (var name in countriesBorderingArgentina)
                {
                    Console.WriteLine(name);
                }
            }

            // 1.4 List the names of the countries that has more than 10,000,000 population [0.5 mark]
            void Question1_4()
            {
                var countries = Country.GetCountries();
                var countriesLargePopulation = countries.Where(country => country.Population > 10000000).Select(country => country.Name);
                Console.WriteLine("\nThe countries that have more than 10,000,000 population are:");
                foreach (var name in countriesLargePopulation)
                {
                    Console.WriteLine(name);
                }
            }

            // 1.5 List the country with highest population [1 mark]
            void Question1_5()
            {
                var countries = Country.GetCountries();
                var countryHighestPopulation = countries.OrderByDescending(country => country.Population).First();
                Console.WriteLine($"\nThe country with the highest population is: {countryHighestPopulation.Name}");
            }

            // 1.6 List all the religion in south America in dictionary order [1 mark]
            void Question1_6()
            {
                var countries = Country.GetCountries();
                var religionsSouthAmerica = countries.SelectMany(country => country.Religions).Distinct().OrderBy(religion => religion);
                Console.WriteLine("\nThe religions in South America in dictionary order are:");
                foreach (var religion in religionsSouthAmerica)
                {
                    Console.WriteLine(religion);
                }
            }
        }
    }
}
