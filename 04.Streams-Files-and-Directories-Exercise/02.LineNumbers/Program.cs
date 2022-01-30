using System;
using System.IO;
using System.Linq;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"text.txt";
            string outputPath = @"output.txt";

            string[] lines = File.ReadAllLines(filePath);

            int count = 1;

            foreach (var line in lines)
            {
                int lettersCount = line.Count(char.IsLetter);
                int puncsCount = line.Count(char.IsPunctuation);

                File.AppendAllText(outputPath, $"Line {count}: {line} ({lettersCount})({puncsCount}){Environment.NewLine}");
                count++;
            }
        }
    }
}
