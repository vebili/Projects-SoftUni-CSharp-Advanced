using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Func<int[], int[]> Add = n => n.Select(x => x + 1).ToArray();
            Func<int[], int[]> Multiply = n => n.Select(x => x * 2).ToArray();
            Func<int[], int[]> Subtract = n => n.Select(x => x - 1).ToArray();
            Action<int[]> Print = n => Console.WriteLine(string.Join(" ", n));
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                switch (command)
                {
                    case "add":
                        input = Add(input);
                        break;
                    case "multiply":
                        input = Multiply(input);
                        break;
                    case "subtract":
                        input = Subtract(input);
                        break;
                    case "print":
                        Print(input);
                        break;
                    default: break;
                }
            }
        }
    }
}