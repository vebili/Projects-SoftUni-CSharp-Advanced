using System;
using System.Collections.Generic;

namespace _04.EvenTimes1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> repeatColletion = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!repeatColletion.ContainsKey(number))
                {
                    repeatColletion.Add(number, 1);
                }
                else
                {
                    repeatColletion[number] += 1;
                }
            }
            foreach (var element in repeatColletion)
            {
                if (element.Value % 2 == 0)
                {
                    Console.WriteLine(element.Key);
                }
            }
        }
    }
}