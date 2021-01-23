using System;
using System.Linq;

namespace _06.JaggedArrayManipulator1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] matrix = new double[n][];
            for (int row = 0; row < n; row++)
            {
                double[] rowValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
                for (int col = 0; col < rowValues.Length; col++)
                {
                    matrix[row] = rowValues;
                }
            }
            for (int row = 0; row < n - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] *= 2;
                        matrix[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] /= 2;
                    }
                    for (int col = 0; col < matrix[row + 1].Length; col++)
                    {
                        matrix[row + 1][col] /= 2;
                    }
                }
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = arguments[0];
                int inputRow = int.Parse(arguments[1]);
                int inputCol = int.Parse(arguments[2]);
                int inputValue = int.Parse(arguments[3]);
                if (inputRow >= 0 && inputRow < n && inputCol >= 0 && inputCol < matrix[inputRow].Length)
                {
                    if (action == "Add")
                    {
                        matrix[inputRow][inputCol] += inputValue;
                    }
                    else
                    {
                        matrix[inputRow][inputCol] -= inputValue;
                    }
                }
                command = Console.ReadLine();
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}