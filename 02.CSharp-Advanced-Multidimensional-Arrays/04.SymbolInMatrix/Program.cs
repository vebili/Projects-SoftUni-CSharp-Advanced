using System;

namespace _04.SymbolInMatrix
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
            char toFind = Console.ReadLine().ToCharArray()[0];
            int elementRow = -1;
            int elementCol = -1;
            bool isFound = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char element = matrix[row, col];
                    if (element == toFind)
                    {
                        elementRow = row;
                        elementCol = col;
                        isFound = true;
                        break;
                    }
                    if (isFound)
                    {
                        break;
                    }
                }
            }
            if (isFound)
            {
                Console.WriteLine($"({elementRow}, {elementCol})");
            }
            else
            {
                Console.WriteLine($"{toFind} does not occur in the matrix ");
            }
        }
    }
}
