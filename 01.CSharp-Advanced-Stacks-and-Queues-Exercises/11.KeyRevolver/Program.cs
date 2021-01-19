using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int sizeGunBarrel = int.Parse(Console.ReadLine());
            int[] bulletsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> bullets = new Stack<int>(bulletsInput);
            int[] locksInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> locks = new Queue<int>(locksInput);
            int valueIntelligence = int.Parse(Console.ReadLine());
            int counterBullets = 0;

            while (locks.Count != 0 && bullets.Count != 0)
            {
                int currentBullet = bullets.Pop();
                int currentLock = locks.Peek();
                counterBullets++;

                if (currentBullet <= currentLock)
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (bullets.Count == 0)
                {
                    break;
                }

                if (counterBullets == sizeGunBarrel)
                {
                    Console.WriteLine("Reloading!");
                    counterBullets = 0;
                }
            }
            if (locks.Count == 0)
            {
                int firedBullets = bulletsInput.Length - bullets.Count;
                int moneyEarned = valueIntelligence - firedBullets * bulletPrice;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}