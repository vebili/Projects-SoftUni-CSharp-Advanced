using System;
using System.Linq;

namespace _04.AddVAT1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Func<double, double> addVat = x => x += x * 0.2;
            double[] result = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select(addVat).ToArray();
            foreach (var item in result)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}