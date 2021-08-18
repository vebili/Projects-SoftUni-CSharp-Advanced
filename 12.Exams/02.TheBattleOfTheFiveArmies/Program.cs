using System;

namespace _02.TheBattleOfTheFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            var armor = int.Parse(Console.ReadLine());
            var rows = int.Parse(Console.ReadLine());

            var world = new char[rows][];
            var armyRow = -1;
            var armyCol = -1;
            var isMissionSuccessful = false;

            for (var row = 0; row < world.GetLength(0); row++)
            {
                var matrixRow = Console.ReadLine();
                world[row] = new char[matrixRow.Length];

                for (var col = 0; col < matrixRow.Length; col++)
                {
                    world[row][col] = matrixRow[col];
                    if (world[row][col] == 'A')
                    {
                        armyRow = row;
                        armyCol = col;
                    }
                }
            }

            while (true)
            {
                var command = Console.ReadLine().Split();
                var direction = command[0];
                var orcRow = int.Parse(command[1]);
                var orcCol = int.Parse(command[2]);

                world[orcRow][orcCol] = 'O';
                world[armyRow][armyCol] = '-';
                armor--;

                switch (direction)
                {
                    case "up":
                        if (armyRow - 1 < 0)
                        {
                            continue;
                        }

                        armyRow--;
                        break;
                    case "down":
                        if (armyRow + 1 == rows)
                        {
                            continue;
                        }

                        armyRow++;
                        break;
                    case "left":
                        if (armyCol - 1 < 0)
                        {
                            continue;
                        }

                        armyCol--;
                        break;
                    case "right":
                        if (armyCol + 1 == world[armyRow].Length)
                        {
                            continue;
                        }

                        armyCol++;
                        break;
                }

                if (armor <= 0)
                {
                    world[armyRow][armyCol] = 'X';
                    break;
                }

                if (world[armyRow][armyCol] == 'O')
                {
                    armor -= 2;
                    if (armor <= 0)
                    {
                        world[armyRow][armyCol] = 'X';
                        break;
                    }
                }
                else if (world[armyRow][armyCol] == 'M')
                {
                    isMissionSuccessful = true;
                    world[armyRow][armyCol] = '-';
                    break;
                }
            }

            Console.WriteLine(isMissionSuccessful
                ? $"The army managed to free the Middle World! Armor left: {armor}"
                : $"The army was defeated at {armyRow};{armyCol}.");

            foreach (var row in world)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
    }
}