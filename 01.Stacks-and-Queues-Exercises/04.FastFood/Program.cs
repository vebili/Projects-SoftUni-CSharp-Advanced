using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalQuantity = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(input);
            if (orders.Count > 0)
            {
                Console.WriteLine(orders.Max());
            }
            while (true)
            {
                if (orders.Count == 0)
                {
                    break;
                }

                int currentOrder = orders.Peek();
                if (currentOrder <= totalQuantity)
                {
                    totalQuantity -= orders.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (orders.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}