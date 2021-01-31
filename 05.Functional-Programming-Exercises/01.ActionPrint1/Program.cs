using System;

namespace _01.ActionPrint1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Action<string> myPrint = PrintStrings;
            for (int i = 0; i < strings.Length; i++)
            {
                myPrint(strings[i]);
            }
        }
        private static void PrintStrings(string str)
        {
            Console.WriteLine(str);
        }
    }
}