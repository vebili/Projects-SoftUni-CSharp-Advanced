using System;
using System.Collections.Generic;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> namesN = new HashSet<string>();
            HashSet<string> namesM = new HashSet<string>();
            HashSet<string> repeated = new HashSet<string>();
            string[] nAndm = Console.ReadLine().Split();
            int n = int.Parse(nAndm[0]);
            int m = int.Parse(nAndm[1]);
            for (int i = 0; i < n + m; i++)
            {
                if (i < n)
                {
                    namesN.Add(Console.ReadLine());
                }
                else
                {
                    namesM.Add(Console.ReadLine());
                }
            }
            foreach (var name in namesN)
            {
                if (namesM.Contains(name))
                {
                    repeated.Add(name);
                }
            }
            Console.WriteLine(string.Join(" ", repeated));
        }
    }
}