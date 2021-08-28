using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            StackA<string> stack = new StackA<string>();
            

            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[]{' ',','},
                                                    StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "END")
                {
                    break;
                }

                string command = input[0];
                List<string> inputList = input.Skip(1).ToList();

                if (command == "Push")
                {
                    foreach (var element in inputList)
                    {
                        stack.Push(element);
                    }
                }
                else
                {
                    stack.Pop();
                }
            }

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
        }
    }
}