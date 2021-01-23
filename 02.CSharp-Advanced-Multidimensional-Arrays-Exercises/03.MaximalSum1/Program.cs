using System;
using System.Linq;

namespace _03.MaximalSum1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[size[0], size[1]];
            for (int row = 0; row < size[0]; row++)
            {
                int[] rowValues = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < size[1]; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            int maxSum = int.MinValue;
            int currentSum = 0;
            int currentRow = -1;
            int currentCol = -1;
            for (int row = 0; row < size[0] - 2; row++)
            {
                for (int col = 0; col < size[1] - 2; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] +
                            matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1]
                            + matrix[row + 2, col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }
            Console.WriteLine("Sum = " + maxSum);
            for (int row = currentRow; row < currentRow + 3; row++)
            {
                for (int col = currentCol; col < currentCol + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}