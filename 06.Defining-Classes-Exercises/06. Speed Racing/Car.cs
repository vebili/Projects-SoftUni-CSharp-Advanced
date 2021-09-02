using System;

namespace SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumption;

            this.TravelledDistance = 0.0;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(double amountOfKm)
        {
            double carMaxDistance = this.FuelAmount / this.FuelConsumptionPerKilometer;

            if (carMaxDistance >= amountOfKm)
            {
                this.TravelledDistance += amountOfKm;
                this.FuelAmount -= amountOfKm * FuelConsumptionPerKilometer;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

    }
}