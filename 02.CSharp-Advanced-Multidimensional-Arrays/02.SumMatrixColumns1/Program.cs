﻿using System;
using System.Linq;

namespace _02.SumMatrixColumns1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[size[0], size[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colData = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colData[col];
                }
            }
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
