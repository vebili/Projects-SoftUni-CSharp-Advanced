using System;

namespace _05.GenericCountMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int numberLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberLines; i++)
            {
                box.Add(Console.ReadLine());
            }

            string stringToCompare = Console.ReadLine();
            
            Console.WriteLine(box.CountGreater(stringToCompare));
        }
    }
}