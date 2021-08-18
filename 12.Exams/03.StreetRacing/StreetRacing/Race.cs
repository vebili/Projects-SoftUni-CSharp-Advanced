using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    public class Race
    {
        private List<Car> participants = new List<Car>();

        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHorsePower;
        }

        public string Name { get; set; }

        public string Type { get; set; }

        public int Laps { get; set; }

        public int Capacity { get; set; }

        public int MaxHorsePower { get; set; }

        public int Count => participants.Count;

        public void Add(Car car)
        {
            var isContaining = participants.FirstOrDefault(c => c.LicensePlate == car.LicensePlate);

            if (isContaining == null
                && Capacity >= Count
                && car.HorsePower <= MaxHorsePower)
            {
                participants.Add(car);
            }
        }
        public bool Remove(string licensePlate)
        {
            var currentPlate = participants.FirstOrDefault(c => c.LicensePlate == licensePlate);

            if (currentPlate != null)
            {
                participants.Remove(currentPlate);
                return true;
            }

            return false;
        }

        public Car FindParticipant(string licensePlate)
        {
            return participants.FirstOrDefault(c => c.LicensePlate == licensePlate);
        }

        public Car GetMostPowerfulCar()
        {
            return participants.OrderByDescending(c => c.HorsePower).FirstOrDefault();
        }

        public string Report()
        {
            var result = new StringBuilder();

            result.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");
            foreach (var participant in participants)
            {
                result.AppendLine(participant.ToString());
            }

            return result.ToString().TrimEnd();
        }
    }
}
