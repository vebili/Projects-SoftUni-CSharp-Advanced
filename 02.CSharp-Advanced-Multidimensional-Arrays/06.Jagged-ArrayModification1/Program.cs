using System;
using System.Linq;

namespace _06.Jagged_ArrayModification1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < rowData.Length; col++)
                {
                    jagged[row] = rowData;
                }
            }
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] arguments = command.Split();
                string action = arguments[0];
                int row = int.Parse(arguments[1]);
                int col = int.Parse(arguments[2]);
                int value = int.Parse(arguments[3]);
                if (row >= 0 && col >= 0 && row < rows && col < jagged[row].Length)
                {
                    switch (action)
                    {
                        case "Add":
                            jagged[row][col] += value;
                            break;
                        case "Subtract":
                            jagged[row][col] -= value;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
                command = Console.ReadLine();
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}