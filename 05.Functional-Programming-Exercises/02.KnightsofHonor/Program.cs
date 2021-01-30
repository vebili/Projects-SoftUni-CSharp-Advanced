using System;
using System.Linq;

namespace _02.KnightsofHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> Print = msg => Console.WriteLine($"Sir {msg}");
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(Print);
        }
    }
}