using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int divider = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ", input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .Where(n => n % divider != 0)));
        }
    }
}