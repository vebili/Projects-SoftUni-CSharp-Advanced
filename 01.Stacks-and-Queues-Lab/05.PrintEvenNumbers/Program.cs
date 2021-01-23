using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>(input);
            List<int> evens = new List<int>();
            while (numbers.Count > 0)
            {
                if (numbers.Peek() % 2 == 0)
                {
                    evens.Add(numbers.Dequeue());
                }
                else
                {
                    numbers.Dequeue();
                }
            }
            Console.WriteLine(string.Join(", ", evens));
        }
    }
}