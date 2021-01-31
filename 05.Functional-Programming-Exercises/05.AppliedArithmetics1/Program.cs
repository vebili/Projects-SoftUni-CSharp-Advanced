using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        Func<int, int> addFunc = x => x + 1;
                        input = Calculator(input, addFunc);
                        break;
                    case "multiply":
                        Func<int, int> multiFunc = x => x * 2;
                        input = Calculator(input, multiFunc);
                        break;
                    case "subtract":
                        Func<int, int> subtFunc = x => x - 1;
                        input = Calculator(input, subtFunc);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", input));
                        break;
                }
                command = Console.ReadLine();
            }
        }
        static List<int> Calculator(List<int> list, Func<int, int> passedFunc) => list.Select(passedFunc).ToList();
    }
}