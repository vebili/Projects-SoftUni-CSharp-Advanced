using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reversed = new Stack<char>(input);

            while (reversed.Any())
            {
                Console.Write(reversed.Pop());
            }
            Console.WriteLine();
        }
    }
}