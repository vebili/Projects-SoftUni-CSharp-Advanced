using System;
using System.Collections.Generic;

namespace _06.Wardrobe1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] separators = { " -> ", "," };
                string[] input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                for (int j = 1; j <= input.Length - 1; j++)
                {
                    string clothing = input[j];
                    if (!wardrobe.ContainsKey(color))
                    {
                        wardrobe.Add(color, new Dictionary<string, int>());
                        if (!wardrobe[color].ContainsKey(clothing))
                        {
                            wardrobe[color].Add(clothing, 1);
                        }
                        else
                        {
                            wardrobe[color][clothing] += 1;
                        }
                    }
                    else
                    {
                        if (!wardrobe[color].ContainsKey(clothing))
                        {
                            wardrobe[color].Add(clothing, 1);
                        }
                        else
                        {
                            wardrobe[color][clothing] += 1;
                        }
                    }
                }
            }
            string[] secondInput = Console.ReadLine().Split();
            string searchingColor = secondInput[0];
            string searchingClothing = secondInput[1];
            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var clothingCountPair in color.Value)
                {
                    if (searchingColor == color.Key && clothingCountPair.Key == searchingClothing)
                    {
                        Console.WriteLine($"* {clothingCountPair.Key} - {clothingCountPair.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothingCountPair.Key} - {clothingCountPair.Value}");
                    }
                }
            }
        }
    }
}