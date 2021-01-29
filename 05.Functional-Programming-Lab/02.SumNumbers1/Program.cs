using System;
using System.Linq;

namespace _02.SumNumbers1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Func<string, int> parse = str => int.Parse(str);
            int[] numbers = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(parse).ToArray();
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Sum());
        }
    }
}