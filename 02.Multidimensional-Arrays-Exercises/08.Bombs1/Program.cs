using System;
using System.Linq;

namespace _08.Bombs1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            string[] bombValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Explode(matrix, bombValues);
            int activeCellCount = 0;
            int sum = 0;
            foreach (var item in matrix)
            {
                if (item > 0)
                {
                    activeCellCount++;
                    sum += item;
                }
            }
            Console.WriteLine($"Alive cells: {activeCellCount}");
            Console.WriteLine($"Sum: {sum}");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");

                }
                Console.WriteLine();
            }
        }
        private static void Explode(int[,] matrix, string[] bombValues)
        {
            foreach (string bomb in bombValues)
            {
                int[] bombData = bomb.Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int bombRow = bombData[0];
                int bombCol = bombData[1];
                int bombValue = matrix[bombRow, bombCol];
                for (int row = bombRow - 1; row <= bombRow + 1; row++)
                {
                    for (int col = bombCol - 1; col <= bombCol + 1; col++)
                    {
                        if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
                        {
                            if (matrix[row, col] <= 0 || bombValue < 0)
                            {
                                continue;
                            }
                            matrix[row, col] -= bombValue;
                        }
                    }
                }
            }
        }
    }
}