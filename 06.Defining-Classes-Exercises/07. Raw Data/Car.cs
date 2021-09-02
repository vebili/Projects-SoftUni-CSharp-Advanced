using System.Collections.Generic;

namespace RawData
{
    public class Car
    {
        public Car(
            string model,
            int engineSpeed,
            int enginePower,
            int cargoWeight,
            string cargoType,
            Tire[] tires)
        {
            Model = model;
            Engine = new Engine(engineSpeed, enginePower);
            Cargo = new Cargo(cargoWeight, cargoType);
            Tires = tires;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }

    }
}