using System;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRows = int.Parse(Console.ReadLine());
            long[][] triangle = new long[numberRows][];
            for (int row = 0; row < numberRows; row++)
            {
                triangle[row] = new long[row + 1];
            }
            triangle[0][0] = 1;
            for (int row = 0; row < numberRows - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }
            for (int row = 0; row < numberRows; row++)
            {
                Console.WriteLine(string.Join(" ", triangle[row]));
            }
        }
    }
}