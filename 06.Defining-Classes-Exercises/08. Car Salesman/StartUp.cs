using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberEngines; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                string power = input[1];
                string displacement = "n/a";
                string efficiency = "n/a";

                if (input.Length == 4)
                {
                    displacement = input[2];
                    efficiency = input[3];
                }
                else if (input.Length == 3)
                {
                    if (char.IsLetter(input[2][0]))
                    {
                        efficiency = input[2];
                    }
                    else
                    {
                        displacement = input[2];
                    }
                }

                Engine currentEngine = new Engine(model, power, displacement, efficiency);

                engines.Add(currentEngine);
            }

            int numberCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberCars; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                string engineModel = input[1];
                string weight = "n/a";
                string color = "n/a";

                if (input.Length == 4)
                {
                    weight = input[2];
                    color = input[3];
                }
                else if (input.Length == 3)
                {
                    if (char.IsLetter(input[2][0]))
                    {
                        color = input[2];
                    }
                    else
                    {
                        weight = input[2];
                    }
                }

                Engine currentEngine = engines.Where(e => e.Model == engineModel).FirstOrDefault();

                Car currentCar = new Car(model, currentEngine, weight, color);
                cars.Add(currentCar);
            }

            foreach (var car in cars)
            {
                car.PrintCar();
            }
        }
    }
}
