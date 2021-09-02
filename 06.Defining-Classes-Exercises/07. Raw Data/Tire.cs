namespace RawData
{
    public class Tire
    {
        public Tire(double tirePressure, int tireAge)
        {
            this.TirePressure = tirePressure;
            this.TireAge = tireAge;
        }

        public int TireAge { get; set; }

        public double TirePressure { get; set; }
    }
}