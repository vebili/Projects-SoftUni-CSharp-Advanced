using System;
using System.Linq;

namespace _06._Quicksort

{
    public class Quick
    {
        public static void Sort<T>(T[] a)
            where T : IComparable<T>
        {

            Sort<T>(a, 0, a.Length - 1);
        }

        private static void Sort<T>(T[] a, int lo, int hi)
            where T : IComparable<T>
        {
            int i = lo;
            int j = hi;
            T pivot = a[(lo + hi) / 2];

            while (i <= j)
            {
                while (a[i].CompareTo(pivot) < 0) i++;

                while (a[j].CompareTo(pivot) > 0) j--;

                if (i <= j)
                {
                    T tmp = a[i];
                    a[i] = a[j];
                    a[j] = tmp;
                    i++;
                    j--;
                }
            }

            if (lo < j) Sort(a, lo, j);

            if (i < hi) Sort(a, i, hi);
        }

        class Quicksort
        {
            static void Main(string[] args)
            {
                int[] array = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                Quick.Sort(array);

                Console.WriteLine(string.Join(" ", array));
            }
        }
    }
}