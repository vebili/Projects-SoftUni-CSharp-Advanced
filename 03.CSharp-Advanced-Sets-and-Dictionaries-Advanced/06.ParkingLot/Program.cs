using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carPlates = new HashSet<string>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "END")
                {
                    break;
                }
                string command = input[0];
                string plate = input[1];
                if (command == "IN")
                {
                    carPlates.Add(plate);
                }
                else if (command == "OUT")
                {
                    carPlates.Remove(plate);
                }
            }
            if (carPlates.Count > 0)
            {
                foreach (var carPlate in carPlates)
                {
                    Console.WriteLine(carPlate);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}