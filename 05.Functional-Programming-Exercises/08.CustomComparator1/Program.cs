using System;
using System.Linq;

namespace _08.CustomComparator1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Array.Sort(nums, Compare);
            Console.WriteLine(string.Join(" ", nums));
        }        static int Compare(int a, int b)
        {
            if (a % 2 != 0 && b % 2 == 0)
            {
                return 1;
            }
            else if (a % 2 == 0 && b % 2 != 0)
            {
                return -1;
            }
            return a.CompareTo(b);
        }
    }
}