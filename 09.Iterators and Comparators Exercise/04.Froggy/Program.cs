using System;
using System.Linq;

namespace _04.Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputStones = Console.ReadLine()
                                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();

            Lake lake = new Lake(inputStones);

            Console.WriteLine(string.Join(", ", lake));

        }
    }
}