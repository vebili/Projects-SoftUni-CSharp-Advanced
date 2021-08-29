using System;

namespace _08.Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();
            string[] input3 = Console.ReadLine().Split();

            string name = input1[0] + " " + input1[1];
            Threeuple<string, string, string> threeuple1 = new Threeuple<string, string, string>(name, input1[2], input1[3]);

            bool isDrunk = input2[2] == "drunk";

            Threeuple<string, int, bool> threeuple2 = new Threeuple<string, int, bool>(input2[0], int.Parse(input2[1]), isDrunk);
            Threeuple<string, double, string> threeuple3 = new Threeuple<string, double, string>(input3[0], double.Parse(input3[1]), input3[2]);

            threeuple1.Print();
            threeuple2.Print();
            threeuple3.Print();
        }
    }
}