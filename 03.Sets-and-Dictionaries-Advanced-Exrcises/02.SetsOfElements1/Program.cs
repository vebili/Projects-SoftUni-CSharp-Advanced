using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = sizes[0];
            int m = sizes[1];
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            int number = 0;
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }
            for (int i = 0; i < m; i++)
            {
                number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }
            int[] intersection = firstSet.Intersect(secondSet).ToArray();
            Console.WriteLine(string.Join(" ", intersection));
        }
    }
}