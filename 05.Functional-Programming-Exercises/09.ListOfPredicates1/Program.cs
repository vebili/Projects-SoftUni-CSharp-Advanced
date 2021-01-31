using System;
using System.Linq;

namespace _09.ListOfPredicates1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Func<int[], int, bool> tester = DivisionChecker;
            for (int i = 1; i <= n; i++)
            {
                if (tester(dividers, i) == true)
                {
                    Console.Write(i + " ");
                }
            }
        }
        private static bool DivisionChecker(int[] nums, int num)
        {
            bool output = true;
            foreach (var item in nums)
            {
                if (num % item != 0)
                {
                    output = false;
                }
            }
            return output;
        }
    }
}