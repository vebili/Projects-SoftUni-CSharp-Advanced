using System;

namespace _02._Generic_Box_of_Integer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            int numberLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberLines; i++)
            {
                box.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(box);
        }
    }
}