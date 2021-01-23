using System;
using System.Collections.Generic;
using System.Text;

namespace _09.SimpleTextEditor1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> text = new Stack<string>();
            StringBuilder strBuild = new StringBuilder();
            text.Push(strBuild.ToString());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                if (command == "1")
                {
                    strBuild.Append(input[1]);
                    text.Push(strBuild.ToString());
                }
                else if (command == "2")
                {
                    int count = int.Parse(input[1]);
                    strBuild.Remove(strBuild.Length - count, count);
                    text.Push(strBuild.ToString());
                }
                else if (command == "3")
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(strBuild[index - 1]);
                }
                else
                {
                    text.Pop();
                    strBuild = new StringBuilder();
                    strBuild.Append(text.Peek());
                }
            }
        }
    }
}