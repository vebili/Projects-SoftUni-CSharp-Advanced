using System;
using System.IO;

namespace _01.OddLines1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine("data", "Input.txt");
            string destination = Path.Combine("data", "Output.txt");

            using (FileStream file = new FileStream(path, FileMode.Open))
            {
                using (TextReader reader = new StreamReader(file))
                {
                    using (FileStream fileWriteStream = new FileStream(destination, FileMode.OpenOrCreate))
                    {
                        using (TextWriter writer = new StreamWriter(fileWriteStream))
                        {
                            string line = reader.ReadLine();
                            int counter = 0;
                            while (line != null)
                            {
                                if (counter % 2 != 0)
                                {
                                    writer.WriteLine(line);
                                }
                                counter++;
                                line = reader.ReadLine();
                            }
                        }
                    }
                }
            }
        }
    }
}