using System;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine, string weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }

        public void PrintCar()
        {
            Console.WriteLine($"{Model}:");
            Console.WriteLine($"  {Engine.Model}:");
            Console.WriteLine($"    Power: {Engine.Power}");
            Console.WriteLine($"    Displacement: {Engine.Displacement}");
            Console.WriteLine($"    Efficiency: {Engine.Efficiency}");
            Console.WriteLine($"  Weight: {Weight}");
            Console.WriteLine($"  Color: {Color}");
        }
    }
}