using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            Queue<string> directions = new Queue<string>(Console.ReadLine().Split());
            char[,] field = new char[size, size];
            int allCoals = 0;
            int startRow = -1;
            int startCol = -1;
            for (int row = 0; row < size; row++)
            {
                char[] fieldLine = Console.ReadLine()
                    .Split()
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < size; col++)
                {
                    field[row, col] = fieldLine[col];
                    if (field[row, col] == 's')
                    {
                        startRow = row;
                        startCol = col;
                    }
                    if (field[row, col] == 'c')
                    {
                        allCoals++;
                    }
                }
            }
            while (directions.Count > 0)
            {
                string command = directions.Dequeue();
                switch (command)
                {
                    case "left":
                        if (IsCoordinatesCorrect(startRow, startCol - 1, field))
                        {
                            startCol = startCol - 1;
                            if (field[startRow, startCol] == 'c')
                            {
                                allCoals -= 1;
                                field[startRow, startCol] = '*';
                            }
                        }
                        break;
                    case "right":
                        if (IsCoordinatesCorrect(startRow, startCol + 1, field))
                        {
                            startCol = startCol + 1;
                            if (field[startRow, startCol] == 'c')
                            {
                                allCoals -= 1;
                                field[startRow, startCol] = '*';
                            }
                        }
                        break;
                    case "up":
                        if (IsCoordinatesCorrect(startRow - 1, startCol, field))
                        {
                            startRow = startRow - 1;
                            if (field[startRow, startCol] == 'c')
                            {
                                allCoals -= 1;
                                field[startRow, startCol] = '*';
                            }
                        }
                        break;
                    case "down":
                        if (IsCoordinatesCorrect(startRow + 1, startCol, field))
                        {
                            startRow = startRow + 1;
                            if (field[startRow, startCol] == 'c')
                            {
                                allCoals -= 1;
                                field[startRow, startCol] = '*';
                            }
                        }
                        break;
                    default:
                        break;
                }
                if (field[startRow, startCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({startRow}, {startCol})");
                    return;
                }
                if (allCoals == 0)
                {
                    Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                    return;
                }
            }
            Console.WriteLine($"{allCoals} coals left. ({startRow}, {startCol})");
        }
        private static bool IsCoordinatesCorrect(int row, int col, char[,] field)
        {
            if (row >= 0
                && row < field.GetLength(0)
                && col >= 0
                && col < field.GetLength(1))
            {
                return true;
            }
            return false;
        }
    }
}