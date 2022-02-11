using System;

namespace _06.GenericCountMethodDouble
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();
            int numberLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberLines; i++)
            {
                box.Add(double.Parse(Console.ReadLine()));
            }

            double numberToCompare = double.Parse(Console.ReadLine());

            Console.WriteLine(box.CountGreater(numberToCompare));
        }
    }
}