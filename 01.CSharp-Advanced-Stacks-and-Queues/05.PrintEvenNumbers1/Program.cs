using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> evens = new Queue<int>(numbers.Where(x => x % 2 == 0));
            Console.WriteLine(string.Join(", ", evens));
        }
    }
}