using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> MinNumber = GetMin;
            Console.WriteLine(MinNumber(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray()));
        }
        private static int GetMin(int[] arr)
        {
            int minNumber = int.MaxValue;
            foreach (var el in arr)
            {
                if (el < minNumber)
                {
                    minNumber = el;
                }
            }
            return minNumber;
        }
    }
}