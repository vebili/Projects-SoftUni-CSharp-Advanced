namespace CarSalesman
{
    public class Engine
    {
        public Engine(string model, string power, string displacement, string efficiency)
               
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }
        public string Model { get; set; }
        public string Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }

    }
}