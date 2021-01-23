using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> occurrencesCollection = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!occurrencesCollection.ContainsKey(input[i]))
                {
                    occurrencesCollection.Add(input[i], 1);
                }
                else
                {
                    occurrencesCollection[input[i]] += 1;
                }
            }
            foreach (var item in occurrencesCollection.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}