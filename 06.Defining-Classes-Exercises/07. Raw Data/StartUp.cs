using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberCars; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                double tire1Pressure = double.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);
                double tire2Pressure = double.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);
                double tire3Pressure = double.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);
                double tire4Pressure = double.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);

                Tire firstTire = new Tire(tire1Pressure, tire1Age);
                Tire secondTire = new Tire(tire1Pressure, tire1Age);
                Tire thirdTire = new Tire(tire1Pressure, tire1Age);
                Tire fourthTire = new Tire(tire1Pressure, tire1Age);

                Tire[] currentTires = new[] { firstTire, secondTire, thirdTire, fourthTire };

                Car currentCar = new Car(model, engineSpeed, enginePower,
                                        cargoWeight, cargoType, currentTires);

                cars.Add(currentCar);
            }

            string filter = Console.ReadLine();

            if (filter == "fragile")
            {
                foreach (var car in cars.Where(x => x.Cargo.CargoType == filter &&
                                                    x.Tires.Any(y => y.TirePressure < 1)))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
            else
            {
                foreach (var car in cars.Where(x => x.Cargo.CargoType == filter && x.Engine.EnginePower > 250))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
    }
}
