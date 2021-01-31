using System;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetASCII = int.Parse(Console.ReadLine());
            string[] inputNames = Console.ReadLine().Split();
            Action<string> Print = name => Console.WriteLine(name);
            Func<string, int, bool> IsSumEqual =
                        (name, ascii) => name.Sum(c => c) >= ascii;
            Func<string[], Func<string, int, bool>, string> FindFirstName =
                        (names, IsSumEqualASCII) => names.FirstOrDefault(n => IsSumEqual(n, targetASCII));
            string result = FindFirstName(inputNames, IsSumEqual);
            Console.WriteLine(result);
        }
    }
}