using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine().ToLower();
            Stack<int> stackedNumbers = new Stack<int>(numbers);
            while (command != "end")
            {
                string[] arguments = command.Split();
                string action = arguments[0];
                if (action == "add")
                {
                    int first = int.Parse(arguments[1]);
                    int second = int.Parse(arguments[2]);
                    stackedNumbers.Push(first);
                    stackedNumbers.Push(second);
                }
                else if (action == "remove")
                {
                    int count = int.Parse(arguments[1]);
                    if (count < stackedNumbers.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stackedNumbers.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: " + stackedNumbers.Sum());
        }
    }
}