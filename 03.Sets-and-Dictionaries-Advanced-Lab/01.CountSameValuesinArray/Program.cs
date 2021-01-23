using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> counter = new Dictionary<double, int>();

            foreach (var el in input)
            {
                if (!counter.ContainsKey(el))
                {
                    counter[el] = 0;
                }

                counter[el]++;
            }

            foreach (var kvp in counter)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}