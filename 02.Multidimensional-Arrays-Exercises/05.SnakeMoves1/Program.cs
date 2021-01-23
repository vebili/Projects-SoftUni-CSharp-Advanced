using System;
using System.Linq;

namespace _05.SnakeMoves1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = size[0];
            int m = size[1];
            string[,] matrix = new string[n, m];
            string snake = Console.ReadLine();
            int count = 0;
            int snakeIndex = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (count % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snake[snakeIndex].ToString();
                        snakeIndex++;
                        if (snakeIndex > snake.Length - 1)
                        {
                            snakeIndex = 0;
                        }
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[snakeIndex].ToString();
                        snakeIndex++;
                        if (snakeIndex > snake.Length - 1)
                        {
                            snakeIndex = 0;
                        }
                    }
                }
                count++;
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}