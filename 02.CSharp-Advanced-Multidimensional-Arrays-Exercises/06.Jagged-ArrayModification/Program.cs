using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());
            int[,] matrix = new int[dimensions, dimensions];
            //int sum = 0;
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
            string input = Console.ReadLine();
            while (input != "END")
            {
                string command = input.Split()[0];
                int row = int.Parse(input.Split()[1]);
                int col = int.Parse(input.Split()[2]);
                int value = int.Parse(input.Split()[3]);

                if (command == "Add" && IsDataValid(row, col, matrix))
                {
                    matrix[row, col] += value;
                }
                else if (command == "Subtract" && IsDataValid(row, col, matrix))
                {
                    matrix[row, col] -= value;
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
                input = Console.ReadLine();
            }
            PrintMatrix(matrix);
        }
        private static void PrintMatrix(int[,] matrix)
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
        private static bool IsDataValid(int row, int col, int[,] matrix)
        {
            if (row < 0
                || row > matrix.GetLength((0)) - 1
                || col < 0
                || col > matrix.GetLength((1)) - 1)
            {
                return false;
            }
            return true;
        }
    }
}