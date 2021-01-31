using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int border = int.Parse(Console.ReadLine());
            int[] deviders = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();
            List<Predicate<int>> predicates = new List<Predicate<int>>();
            List<int> correctNumbers = new List<int>();

            foreach (var devider in deviders)
            {
                Predicate<int> pred = n => n % devider == 0;
                predicates.Add(pred);
            }
            for (int i = 1; i <= border; i++)
            {
                if (IsValid(predicates, i))
                {
                    correctNumbers.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", correctNumbers));
        }
        private static bool IsValid(List<Predicate<int>> predicates, int i)
        {
            foreach (var predicate in predicates)
            {
                if (!predicate(i))
                {
                    return false;
                }
            }
            return true;
        }
    }
}