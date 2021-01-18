using System;
using System.Collections.Generic;

namespace _07.HotPatato1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> kids = new Queue<string>(names);
            int counter = 1;
            while (kids.Count > 1)
            {
                string currentName = kids.Dequeue();
                if (counter == n)
                {
                    Console.WriteLine($"Removed {currentName}");
                    counter = 0;
                }
                else
                {
                    kids.Enqueue(currentName);
                }
                counter++;
            }
            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}