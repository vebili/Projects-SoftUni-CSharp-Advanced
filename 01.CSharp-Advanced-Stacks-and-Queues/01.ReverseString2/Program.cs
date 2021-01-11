using System;
using System.Collections.Generic;

namespace _01.ReverseStrings2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> reversed = new Stack<char>(input);

            while (reversed.Count > 0)
            {
                Console.Write(reversed.Pop());
            }
            Console.WriteLine();
        }
    }
}