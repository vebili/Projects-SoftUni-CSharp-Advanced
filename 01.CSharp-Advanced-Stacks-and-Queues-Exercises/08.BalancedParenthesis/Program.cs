using System;
using System.Collections.Generic;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> parenthesesStack = new Stack<char>();
            Dictionary<char, char> parentheses = new Dictionary<char, char>();
            parentheses.Add('{', '}');
            parentheses.Add('[', ']');
            parentheses.Add('(', ')');
            bool isBalanced = true;
            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (parentheses.ContainsKey(input[i]))  // opening parenthesis
                    parenthesesStack.Push(input[i]);
                else if (parenthesesStack.Count == 0 || input[i] != parentheses[parenthesesStack.Peek()])   // non-matching opening & closing parentheses
                {
                    isBalanced = false;
                    break;
                }
                else if (input[i] == parentheses[parenthesesStack.Peek()])  // matching opening & closing parentheses
                    parenthesesStack.Pop();
            }
            if (isBalanced) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}