using System;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> name = new Queue<string>();
            while (input != "End")
            {
                if (input == "Paid")
                {
                    foreach (var item in name)
                    {
                        Console.WriteLine(item);
                    }
                    name.Clear();
                }
                else
                {
                    name.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{name.Count} people remaining.");
        }
    }
}