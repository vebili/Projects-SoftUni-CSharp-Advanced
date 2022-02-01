using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> extensionNameSize = new Dictionary<string, Dictionary<string, double>>();

            string path = ".";
            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string outputFileNAme = @"report.txt";
            string outputPath = Path.Combine(pathDesktop, outputFileNAme);

            DirectoryInfo dir = new DirectoryInfo(path);

            foreach (var file in dir.GetFiles())
            {
                string fileName = file.Name;
                string extension = file.Extension;
                double size = file.Length / 1024.0;

                if (!extensionNameSize.ContainsKey(extension))
                {
                    extensionNameSize[extension] = new Dictionary<string, double>();
                }

                if (!extensionNameSize[extension].ContainsKey(fileName))
                {
                    extensionNameSize[extension][fileName] = size;
                }
            }

            var sortedList = extensionNameSize
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);


            foreach (var (extension, fileName) in sortedList)
            {
                File.AppendAllText(outputPath, extension + Environment.NewLine);
                foreach (var (file, size) in fileName.OrderByDescending(x => x.Value))
                {
                    File.AppendAllText(outputPath, $"--{file} - {Math.Round(size, 3)}kb{Environment.NewLine}");
                }
            }
        }
    }
}
