using System;
using System.Linq;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());
            int[,] matrix = new int[dimensions, dimensions];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            string[] bombCoordinates = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            for (int i = 0; i < bombCoordinates.Length; i++)
            {
                int bombRow = int.Parse(bombCoordinates[i].Split(',')[0]);
                int bombCol = int.Parse(bombCoordinates[i].Split(',')[1]);
                int bombValue = matrix[bombRow, bombCol];

                if (bombValue > 0)
                {
                    matrix = Explode(bombRow, bombCol, bombValue, matrix);
                }
            }
            int aliveCells = 0;
            int sumAlive = 0;
            foreach (var cell in matrix)
            {
                if (cell > 0)
                {
                    aliveCells++;
                    sumAlive += cell;
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sumAlive}");
            Print(matrix);
        }
        private static int[,] Explode(int bombRow, int bombCol, int bombValue, int[,] matrix)
        {
            if (IsInMatrix(bombRow - 1, bombCol - 1, matrix))
            {
                if (matrix[bombRow - 1, bombCol - 1] > 0)
                {
                    matrix[bombRow - 1, bombCol - 1] -= bombValue;
                }
            }
            if (IsInMatrix(bombRow - 1, bombCol, matrix))
            {
                if (matrix[bombRow - 1, bombCol] > 0)
                {
                    matrix[bombRow - 1, bombCol] -= bombValue;
                }
            }
            if (IsInMatrix(bombRow - 1, bombCol + 1, matrix))
            {
                if (matrix[bombRow - 1, bombCol + 1] > 0)
                {
                    matrix[bombRow - 1, bombCol + 1] -= bombValue;
                }
            }
            if (IsInMatrix(bombRow, bombCol - 1, matrix))
            {
                if (matrix[bombRow, bombCol - 1] > 0)
                {
                    matrix[bombRow, bombCol - 1] -= bombValue;
                }
            }
            if (IsInMatrix(bombRow, bombCol + 1, matrix))
            {
                if (matrix[bombRow, bombCol + 1] > 0)
                {
                    matrix[bombRow, bombCol + 1] -= bombValue;
                }
            }
            if (IsInMatrix(bombRow + 1, bombCol - 1, matrix))
            {
                if (matrix[bombRow + 1, bombCol - 1] > 0)
                {
                    matrix[bombRow + 1, bombCol - 1] -= bombValue;
                }
            }
            if (IsInMatrix(bombRow + 1, bombCol, matrix))
            {
                if (matrix[bombRow + 1, bombCol] > 0)
                {
                    matrix[bombRow + 1, bombCol] -= bombValue;
                }
            }
            if (IsInMatrix(bombRow + 1, bombCol + 1, matrix))
            {
                if (matrix[bombRow + 1, bombCol + 1] > 0)
                {
                    matrix[bombRow + 1, bombCol + 1] -= bombValue;
                }
            }
            matrix[bombRow, bombCol] = 0;
            return matrix;
        }
        private static bool IsInMatrix(int row, int col, int[,] matrix)
        {
            if (row >= 0
                && row < matrix.GetLength(0)
                && col >= 0
                && col < matrix.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void Print(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col > 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}