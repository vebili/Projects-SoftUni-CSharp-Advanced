using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.BalancedParenthesis1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> bracketStack = new Stack<char>();
            foreach (var symbol in input)
            {
                if (bracketStack.Any())
                {
                    char check = bracketStack.Peek();
                    if (check == '{' && symbol == '}')
                    {
                        bracketStack.Pop();
                        continue;
                    }
                    else if (check == '[' && symbol == ']')
                    {
                        bracketStack.Pop();
                        continue;
                    }
                    else if (check == '(' && symbol == ')')
                    {
                        bracketStack.Pop();
                        continue;
                    }
                }
                bracketStack.Push(symbol);
            }
            Console.WriteLine(!bracketStack.Any() ? "YES" : "NO");
        }
    }
}