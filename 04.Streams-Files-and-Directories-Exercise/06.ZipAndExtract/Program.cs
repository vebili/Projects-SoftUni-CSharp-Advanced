using System;
using System.IO;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @".\copyMe.png";
            string zipPath = @"D:\result.zip";
            string pathExtractedFile = @"D:\";
            ZipFile.CreateFromDirectory(filePath, zipPath);
            ZipFile.ExtractToDirectory(zipPath, pathExtractedFile);
        }
    }
}
