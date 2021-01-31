using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.TriFunction1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Func<string, int, bool> isPassedCondition = (name, length) => name.Sum(x => x) >= length;

            Func<List<string>, Func<string, int, bool>, int, string> mainFunc =
                (names, isPassedCondition, total) => names.FirstOrDefault(x => isPassedCondition(x, total));

            string result = mainFunc(names, isPassedCondition, length);
            Console.WriteLine(result);
        }
    }
}