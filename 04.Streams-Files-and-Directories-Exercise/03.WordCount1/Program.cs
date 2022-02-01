using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.WordCount1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            string fileWords = @"words.txt";
            string fileText = @"text.txt";
            string fileActual = @"actualResult.txt";
            string fileExpected = @"expectedResult.txt";

            string text = File.ReadAllText(fileText);
            string[] words = File.ReadAllLines(fileWords);

            foreach (var word in words)
            {
                if (!wordsCount.ContainsKey(word))
                {
                    wordsCount[word] = 0;
                }
            }

            string pattern = @"[A-Za-z]+";
            Regex rg = new Regex(pattern);

            foreach (Match match in rg.Matches(text.ToLower()))
            {
                if (wordsCount.ContainsKey(match.Value))
                {
                    wordsCount[match.Value]++;
                }
            }

            foreach (var (key, value) in wordsCount)
            {
                File.AppendAllText(fileActual, $"{key} - {value}{Environment.NewLine}");
            }

            foreach (var (key, value) in wordsCount.OrderByDescending(x => x.Value))
            {
                File.AppendAllText(fileExpected, $"{key} - {value}{Environment.NewLine}");
            }

        }
    }
}
