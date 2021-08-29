using System;

namespace _03._Generic_Swap_Method_String
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

            string[] inputIndexes = Console.ReadLine().Split();
            int index1 = int.Parse(inputIndexes[0]);
            int index2 = int.Parse(inputIndexes[1]);

            box.Swap(index1, index2);

            Console.WriteLine(box);
        }
    }
}