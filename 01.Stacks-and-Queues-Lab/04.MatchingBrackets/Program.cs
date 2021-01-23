using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> bracketPositions = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                int openingBracket = 0;
                if (input[i] == '(')
                {
                    bracketPositions.Push(i);
                }
                else if (input[i] == ')')
                {
                    openingBracket = bracketPositions.Pop();
                    Console.WriteLine(input.Substring(openingBracket, i - openingBracket + 1));
                }
            }
        }
    }
}