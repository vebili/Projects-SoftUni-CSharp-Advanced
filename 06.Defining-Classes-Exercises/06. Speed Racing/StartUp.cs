using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberCars = int.Parse(Console.ReadLine());

            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < numberCars; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionFor1km = double.Parse(input[2]);

                Car currentCar = new Car(model, fuelAmount, fuelConsumptionFor1km);

                if (!cars.ContainsKey(model))
                {
                    cars[model] = currentCar;
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }

                string carModel = input[1];
                double amountOfKm = double.Parse(input[2]);

                if (cars.ContainsKey(carModel))
                {
                    cars[carModel].Drive(amountOfKm);
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} {car.Value.FuelAmount:f2} {car.Value.TravelledDistance}");
            }
        }
    }
}
