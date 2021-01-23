using System;
using System.Collections.Generic;

namespace _10.Crossroads1
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeGreen = int.Parse(Console.ReadLine());
            int timeFree = int.Parse(Console.ReadLine());
            int totalCarsPassed = 0;
            char characterHit = ' ';
            string crashedCar = string.Empty;
            bool isCarHit = false;
            Queue<string> cars = new Queue<string>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                    input = Console.ReadLine();
                    continue;
                }
                int currentTimeGreen = timeGreen;
                while (cars.Count > 0 && currentTimeGreen > 0)
                {
                    string currentCarToPass = cars.Dequeue();
                    int carLength = currentCarToPass.Length;
                    int totalTimeToPass = currentTimeGreen + timeFree;
                    if (currentTimeGreen - carLength >= 0)
                    {
                        //success passed
                        currentTimeGreen -= carLength;
                        totalCarsPassed++;
                    }
                    else if (currentTimeGreen - carLength < 0)
                    {
                        if (totalTimeToPass - carLength < 0)
                        {
                            characterHit = currentCarToPass[totalTimeToPass];
                            isCarHit = true;
                            crashedCar = currentCarToPass;
                            break;
                        }
                        totalCarsPassed++;
                        break;
                    }
                }
                if (isCarHit)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if (isCarHit)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{crashedCar} was hit at {characterHit}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
            }
        }
    }
}