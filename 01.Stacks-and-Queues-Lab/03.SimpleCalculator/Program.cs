using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Reverse().ToArray();
            Stack<string> result = new Stack<string>(input);
            while (result.Count > 1)
            {
                int calc = 0;
                int first = int.Parse(result.Pop());
                string operation = result.Pop();
                int second = int.Parse(result.Pop());
                if (operation == "+")
                {
                    calc = first + second;
                }
                else
                {
                    calc = first - second;
                }
                result.Push(calc.ToString());
            }
            Console.WriteLine(result.Pop().ToString());
        }
    }
}