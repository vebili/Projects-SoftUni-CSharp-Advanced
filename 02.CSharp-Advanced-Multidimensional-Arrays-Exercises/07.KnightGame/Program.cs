using System;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());
            char[,] matrix = new char[dimensions, dimensions];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] elements = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            int removedKnights = 0;
            while (true)
            {
                int maxConflicts = 0;
                int maxConflictsRow = -1;
                int maxConflictsCol = -1;
                int countConflictKnights = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        int currentConflicts = 0;
                        char currentCell = matrix[row, col];
                        if (currentCell == 'K')
                        {
                            if (IsUpLeftTaken(row, col, matrix))
                            {
                                currentConflicts++;
                            }
                            if (IsUpRightTaken(row, col, matrix))
                            {
                                currentConflicts++;
                            }
                            if (IsLeftUpTaken(row, col, matrix))
                            {
                                currentConflicts++;
                            }
                            if (IsLeftDownTaken(row, col, matrix))
                            {
                                currentConflicts++;
                            }
                            if (IsDownLeftTaken(row, col, matrix))
                            {
                                currentConflicts++;
                            }
                            if (IsDownRightTaken(row, col, matrix))
                            {
                                currentConflicts++;
                            }
                            if (IsRightUpTaken(row, col, matrix))
                            {
                                currentConflicts++;
                            }
                            if (IsRightDownTaken(row, col, matrix))
                            {
                                currentConflicts++;
                            }
                            if (currentConflicts > maxConflicts)
                            {
                                maxConflicts = currentConflicts;
                                maxConflictsRow = row;
                                maxConflictsCol = col;
                                countConflictKnights++;
                            }
                        }
                    }
                }
                if (countConflictKnights == 0)
                {
                    break;
                }
                else
                {
                    matrix[maxConflictsRow, maxConflictsCol] = '0';
                    removedKnights++;
                }
            }
            Console.WriteLine(removedKnights);
        }
        private static void Print(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        private static bool IsRightDownTaken(int row, int col, char[,] matrix)
        {
            if (row + 1 > matrix.GetLength(0) - 1
                || col + 2 > matrix.GetLength(1) - 1)
            {
                return false;
            }

            if (matrix[row + 1, col + 2] == '0')
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool IsRightUpTaken(int row, int col, char[,] matrix)
        {
            if (row - 1 < 0
                || col + 2 > matrix.GetLength(1) - 1)
            {
                return false;
            }

            if (matrix[row - 1, col + 2] == '0')
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool IsDownRightTaken(int row, int col, char[,] matrix)
        {
            if (row + 2 > matrix.GetLength(0) - 1
                || col + 1 > matrix.GetLength(1) - 1)
            {
                return false;
            }

            if (matrix[row + 2, col + 1] == '0')
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool IsDownLeftTaken(int row, int col, char[,] matrix)
        {
            if (row + 2 > matrix.GetLength(0) - 1
                || col - 1 < 0)
            {
                return false;
            }

            if (matrix[row + 2, col - 1] == '0')
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool IsLeftDownTaken(int row, int col, char[,] matrix)
        {
            if (row + 1 > matrix.GetLength(0) - 1
                || col - 2 < 0)
            {
                return false;
            }

            if (matrix[row + 1, col - 2] == '0')
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool IsLeftUpTaken(int row, int col, char[,] matrix)
        {
            if (row - 1 < 0
                || col - 2 < 0)
            {
                return false;
            }

            if (matrix[row - 1, col - 2] == '0')
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool IsUpRightTaken(int row, int col, char[,] matrix)
        {
            if (row - 2 < 0
                || col + 1 > matrix.GetLength(1) - 1)
            {
                return false;
            }

            if (matrix[row - 2, col + 1] == '0')
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool IsUpLeftTaken(int row, int col, char[,] matrix)
        {
            if (row - 2 < 0
                || col - 1 < 0)
            {
                return false;
            }
            if (matrix[row - 2, col - 1] == '0')
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}