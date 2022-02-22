using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BirthdayCelebration
{
    class Program
    {
        static void Main(string[] args)
        {
            var guests = new LinkedList<int>(Console
                .ReadLine()
                .Split()
                .Select(int.Parse));

            var plates = new Stack<int>(Console
                .ReadLine()
                .Split()
                .Select(int.Parse));

            var wastedGramsOfFood = 0;

            while (guests.Any() && plates.Any())
            {
                var currentGuest = guests.First();
                var currentPlate = plates.Peek();

                if (currentGuest < currentPlate)
                {
                    wastedGramsOfFood += currentPlate - currentGuest;
                    guests.RemoveFirst();
                    plates.Pop();
                }
                else if (currentGuest > currentPlate)
                {
                    var stillHungry = currentGuest - currentPlate;
                    plates.Pop();
                    guests.RemoveFirst();
                    guests.AddFirst(stillHungry);
                }
                else
                {
                    plates.Pop();
                    guests.RemoveFirst();
                }
            }

            Console.WriteLine(plates.Any() ? $"Plates: {string.Join(" ", plates)}" : $"Guests: {string.Join(" ", guests)}");
            Console.WriteLine($"Wasted grams of food: {wastedGramsOfFood}");
        }
    }
}