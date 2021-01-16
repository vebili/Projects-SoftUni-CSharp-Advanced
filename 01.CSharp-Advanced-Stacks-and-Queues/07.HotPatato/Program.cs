using System;
using System.Collections.Generic;

namespace _07.HotPatato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> kids = new Queue<string>(input);
            int counter = 0;
            while (kids.Count > 1)
            {
                counter++;
                string kid = kids.Dequeue();
                if (counter == n)
                {
                    counter = 0;
                    Console.WriteLine("Removed " + kid);
                }
                else
                {
                    kids.Enqueue(kid);
                }
            }
            Console.WriteLine("Last is " + kids.Dequeue());
        }
    }
}