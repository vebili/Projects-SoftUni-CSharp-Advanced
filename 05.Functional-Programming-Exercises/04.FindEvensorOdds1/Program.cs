using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensorOdds1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> result = new List<int>();
            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                result.Add(i);
            }
            string command = Console.ReadLine();
            Func<int, bool> pred = x => x % 2 == 0;
            if (command == "odd")
            {
                pred = x => x % 2 != 0;
            }
            Console.WriteLine(string.Join(" ", result.Where(pred)));
        }
    }
}