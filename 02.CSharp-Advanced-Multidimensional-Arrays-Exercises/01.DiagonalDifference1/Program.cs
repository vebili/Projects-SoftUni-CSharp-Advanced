using System;
using System.Linq;

namespace _01.DiagonalDifference1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            int sumLeftDiagonal = 0;
            int sumRightDiagonal = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == col)
                    {
                        sumLeftDiagonal += matrix[row, col];
                    }
                    if ((row + col) == n - 1)
                    {
                        sumRightDiagonal += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(Math.Abs(sumLeftDiagonal - sumRightDiagonal)); ;
        }
    }
}