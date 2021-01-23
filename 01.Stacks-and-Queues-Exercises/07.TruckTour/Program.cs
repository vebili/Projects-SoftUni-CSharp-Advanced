using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPetrolPumps = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();
            for (int i = 0; i < numberPetrolPumps; i++)
            {
                int[] dataForPump = Console.ReadLine().Split().Select(int.Parse).ToArray();
                pumps.Enqueue(dataForPump);
            }
            int index = 0;

            while (true)
            {
                int totalfuel = 0;
                foreach (var pump in pumps)
                {
                    int fuel = pump[0];
                    int distance = pump[1];

                    totalfuel += fuel - distance;

                    if (totalfuel < 0)
                    {
                        int[] currentPump = pumps.Dequeue();
                        pumps.Enqueue(currentPump);
                        index++;
                        break;
                    }
                }
                if (totalfuel >= 0)
                {
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}