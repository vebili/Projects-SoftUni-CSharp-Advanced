using System;

namespace _07.KnightGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] board = new char[n, n];
            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    board[row, col] = rowData[col];
                }
            }
            int removedCount = 0;
            while (true)
            {
                int maxAttackedKnightsCount = 0;
                int knightRow = -1;
                int knightCol = -1;
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char symbol = board[row, col];
                        if (symbol != 'K')
                        {
                            continue;
                        }
                        int count = GetCountOfAttackedKnights(board, row, col);
                        if (count > maxAttackedKnightsCount)
                        {
                            maxAttackedKnightsCount = count;
                            knightRow = row;
                            knightCol = col;
                        }
                    }
                }
                if (maxAttackedKnightsCount == 0)
                {
                    break;
                }
                board[knightRow, knightCol] = '0';
                removedCount++;
            }
            Console.WriteLine(removedCount);
        }
        private static int GetCountOfAttackedKnights(char[,] board, int row, int col)
        {
            int count = 0;
            if (ContainsKnight(board, row - 2, col - 1))
            {
                count++;
            }
            if (ContainsKnight(board, row - 2, col + 1))
            {
                count++;
            }
            if (ContainsKnight(board, row - 1, col - 2))
            {
                count++;
            }
            if (ContainsKnight(board, row - 1, col + 2))
            {
                count++;
            }
            if (ContainsKnight(board, row + 1, col - 2))
            {
                count++;
            }
            if (ContainsKnight(board, row + 1, col + 2))
            {
                count++;
            }
            if (ContainsKnight(board, row + 2, col - 1))
            {
                count++;
            }
            if (ContainsKnight(board, row + 2, col + 1))
            {
                count++;
            }
            return count;
        }
        private static bool ContainsKnight(char[,] board, int row, int col)
        {
            if (!isValidCell(row, col, board.GetLength(0)))
            {
                return false;
            }
            return board[row, col] == 'K';
        }
        private static bool isValidCell(int row, int col, int lenght)
        {
            return row >= 0 && row < lenght && col >= 0 && col < lenght;
        }
    }
}