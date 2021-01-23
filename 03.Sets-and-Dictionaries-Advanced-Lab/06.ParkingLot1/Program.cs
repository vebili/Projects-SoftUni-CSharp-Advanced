using System;
using System.Collections.Generic;

namespace _06.ParkingLot1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> parkingLot = new HashSet<string>();
            while (input != "END")
            {
                string[] arguments = input.Split(", ");
                string command = arguments[0];
                string plateNumber = arguments[1];
                if (command == "IN")
                {
                    parkingLot.Add(plateNumber);
                }
                else
                {
                    parkingLot.Remove(plateNumber);
                }
                input = Console.ReadLine();
            }
            if (parkingLot.Count > 0)
            {
                foreach (var number in parkingLot)
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}