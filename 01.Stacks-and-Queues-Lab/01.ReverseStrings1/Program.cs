using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseStrings1
{
    class Program
    {
        static void Main(string[] args)
        {
            var reversed = new Stack<char>();
            Console.ReadLine().ToCharArray().ToList().ForEach(x => reversed.Push(x));
            Console.WriteLine(string.Join(string.Empty, reversed));
        }
    }
}