using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();
            int n = int.Parse(Console.ReadLine());
            numbers = numbers.Where(x => x % n != 0).ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}