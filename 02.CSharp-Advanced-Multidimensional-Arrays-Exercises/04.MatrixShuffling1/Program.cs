using System;
using System.Linq;

namespace _04.MatrixShuffling1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[,] matrix = new string[size[0], size[1]];
            for (int row = 0; row < size[0]; row++)
            {
                string[] rowValues = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int col = 0; col < size[1]; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            string command = Console.ReadLine();
            while (command != "END")
            {
                string action = string.Empty;
                int row1 = 0;
                int col1 = 0;
                int row2 = 0;
                int col2 = 0;
                string[] arguments = command.Split();
                if (arguments.Length == 5)
                {
                    action = arguments[0];
                    row1 = int.Parse(arguments[1]);
                    col1 = int.Parse(arguments[2]);
                    row2 = int.Parse(arguments[3]);
                    col2 = int.Parse(arguments[4]);
                }
                if (action == "swap" && row1 < size[0] && row2 < size[0] && col1 < size[1] && col2 < size[1])
                {
                    string temp = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = temp;
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine();
            }
        }
    }
}