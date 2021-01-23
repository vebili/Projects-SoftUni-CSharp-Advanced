using System;
using System.Collections.Generic;

namespace _04.CitiesByContinentAndCountry1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> infoCollection = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string city = input[2];
                if (!infoCollection.ContainsKey(continent))
                {
                    infoCollection.Add(continent, new Dictionary<string, List<string>>());
                    infoCollection[continent].Add(country, new List<string>());
                    infoCollection[continent][country].Add(city);
                }
                else if (!infoCollection[continent].ContainsKey(country))
                {
                    infoCollection[continent].Add(country, new List<string>());
                    infoCollection[continent][country].Add(city);
                }
                else
                {
                    infoCollection[continent][country].Add(city);
                }
            }
            foreach (var item in infoCollection)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var country in item.Value)
                {
                    Console.Write($"{country.Key} -> ");
                    Console.Write(string.Join(", ", country.Value));
                    Console.WriteLine();
                }
            }
        }
    }
}