using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int filterLenght = int.Parse(Console.ReadLine());

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(n => n.Length <= filterLenght)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}