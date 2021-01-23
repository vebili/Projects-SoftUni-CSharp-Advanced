using System;
using System.Collections.Generic;

namespace _04.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continentCountryCities = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = input[0];
                string country = input[1];
                string city = input[2];
                if (!continentCountryCities.ContainsKey(continent))
                {
                    continentCountryCities[continent] = new Dictionary<string, List<string>>();
                }
                if (!continentCountryCities[continent].ContainsKey(country))
                {
                    continentCountryCities[continent][country] = new List<string>();
                }
                continentCountryCities[continent][country].Add(city);
            }
            foreach (var continent in continentCountryCities)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"    {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}