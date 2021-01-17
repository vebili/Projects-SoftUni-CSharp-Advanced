using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int[] input = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];

            int[] numbers = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

            int numbersToPush = Math.Min(n, numbers.Length);
            for (int i = 0; i < numbersToPush; i++)
            {
                stack.Push(numbers[i]);
            }

            int numbersToPop = Math.Min(s, stack.Count);
            for (int i = 0; i < numbersToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}