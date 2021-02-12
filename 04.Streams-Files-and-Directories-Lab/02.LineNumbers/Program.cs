using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"files/02.LineNumbers/";
            string fileInput = @"Input.txt";
            string fileOutput = @"Output.txt";
            string inputPath = Path.Combine(path, fileInput);
            string outputPath = Path.Combine(path, fileOutput);

            using (StreamReader reader = new StreamReader(inputPath))
            {
                int counter = 1;
                string line = reader.ReadLine();

                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    while (line != null)
                    {
                        writer.WriteLine($"{counter++}. {line}");
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}