using System;
using System.Collections.Generic;

namespace _07.SoftUniParty1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> VIP = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();
            while (input != "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    VIP.Add(input);
                }
                else
                {
                    regular.Add(input);
                }
                input = Console.ReadLine();
            }
            string secondInput = Console.ReadLine();
            while (secondInput != "END")
            {
                if (VIP.Contains(secondInput) || regular.Contains(secondInput))
                {
                    VIP.Remove(secondInput);
                    regular.Remove(secondInput);
                }
                secondInput = Console.ReadLine();
            }
            Console.WriteLine(VIP.Count + regular.Count);
            foreach (var item in VIP)
            {
                Console.WriteLine(item);
            }
            foreach (var item in regular)
            {
                Console.WriteLine(item);
            }
        }
    }
}