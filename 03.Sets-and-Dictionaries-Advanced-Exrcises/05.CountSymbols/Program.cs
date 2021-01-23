using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                char symb = input[i];

                if (!charCount.ContainsKey(symb))
                {
                    charCount[symb] = 0;
                }
                charCount[symb]++;
            }
            foreach (var symb in charCount.OrderBy(s => s.Key))
            {
                Console.WriteLine($"{symb.Key}: {symb.Value} time/s");
            }
        }
    }
}