using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> colorItemCount = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                string[] items = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
                if (!colorItemCount.ContainsKey(color))
                {
                    colorItemCount[color] = new Dictionary<string, int>();
                }
                for (int j = 0; j < items.Length; j++)
                {
                    string item = items[j];
                    if (!colorItemCount[color].ContainsKey(item))
                    {
                        colorItemCount[color][item] = 0;
                    }
                    colorItemCount[color][item]++;
                }
            }
            string[] searched = Console.ReadLine().Split();
            string searchedColor = searched[0];
            string searchedItem = searched[1];
            foreach (var color in colorItemCount)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var item in color.Value)
                {
                    if (color.Key == searchedColor && item.Key == searchedItem)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}