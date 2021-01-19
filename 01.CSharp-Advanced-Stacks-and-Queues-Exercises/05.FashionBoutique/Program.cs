using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> clothes = new Stack<int>(input);
            int rackCapacity = int.Parse(Console.ReadLine());
            int usedRacks = 1;
            int currentSum = 0;
            if (clothes.Count == 0 || rackCapacity == 0)
            {
                Console.WriteLine(0);
                return;
            }
            while (clothes.Count > 0)
            {
                int currentValue = clothes.Peek();

                if (currentValue + currentSum == rackCapacity)
                {
                    clothes.Pop();
                    usedRacks++;
                    currentSum = 0;
                    if (clothes.Count == 0)
                    {
                        usedRacks--;
                    }
                }
                else if (currentValue + currentSum < rackCapacity)
                {
                    currentSum += clothes.Pop();

                }
                else
                {
                    usedRacks++;
                    currentSum = clothes.Pop();
                }
            }
            Console.WriteLine(usedRacks);
        }
    }
}