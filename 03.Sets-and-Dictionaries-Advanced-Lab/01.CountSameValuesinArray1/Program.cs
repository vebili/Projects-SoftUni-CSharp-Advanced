using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesinArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> occurance = new Dictionary<double, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!occurance.ContainsKey(input[i]))
                {
                    occurance.Add(input[i], 1);
                }
                else
                {
                    occurance[input[i]] += 1;
                }
            }
            foreach (var item in occurance)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}