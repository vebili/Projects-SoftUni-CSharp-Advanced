using System;

namespace _07.PascalTriangle1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            long[][] PTriangle = new long[rows][];
            int initValue = 1;
            for (long row = 0; row < rows; row++)
            {
                PTriangle[row] = new long[initValue];
                long[] currentRow = PTriangle[row];
                currentRow[0] = 1;
                currentRow[currentRow.Length - 1] = 1;
                initValue++;
                if (currentRow.Length > 2)
                {
                    for (int i = 1; i < currentRow.Length - 1; i++)
                    {
                        long[] previousRow = PTriangle[row - 1];
                        long previousRowSum = previousRow[i] + previousRow[i - 1];
                        currentRow[i] = previousRowSum;
                    }
                }
            }
            foreach (var item in PTriangle)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}