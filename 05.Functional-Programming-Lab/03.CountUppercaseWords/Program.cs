using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> myFunc = word => char.IsUpper(word[0]);
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(myFunc)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}