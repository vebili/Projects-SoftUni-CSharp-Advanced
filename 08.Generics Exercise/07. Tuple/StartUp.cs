using System;

namespace _07.Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();
            string[] input3 = Console.ReadLine().Split();

            string name = input1[0] + " " + input1[1];
            Tuple<string,string> tuple1 = new Tuple<string, string>(name, input1[2]);
            Tuple<string,int> tuple2 = new Tuple<string, int>(input2[0], int.Parse(input2[1]));
            Tuple<int,double> tuple3 = new Tuple<int, double>(int.Parse(input3[0]), double.Parse(input3[1]));


            tuple1.Print();
            tuple2.Print();
            tuple3.Print();

        }
    }
}