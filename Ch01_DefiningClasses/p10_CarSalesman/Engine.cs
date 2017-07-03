namespace p10_CarSalesman
{
    public class Engine
    {
        private string model;
        private int power;
        private int displacements;
        private string efficiency;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

        public int Displacements
        {
            get { return this.displacements; }
            set { this.displacements = value; }
        }

        public string Efficiency
        {
            get { return this.efficiency; }
            set { this.efficiency = value; }
        }


        public Engine(string model, int power, int displacements, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacements = displacements;
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power) : this(model, power, 0, "n/a")
        {
        }
        public Engine(string model, int power, int displacements) : this(model, power, displacements, "n/a")
        {
        }
        public Engine(string model, int power, string efficiency) : this(model, power, 0, efficiency)
        {
        }

        public override string ToString()
        {
            string disp = this.Displacements == 0 ? "n/a" : this.Displacements.ToString();
            return $"  {this.Model}:\n    Power: {this.Power}\n    Displacement: {disp}\n    Efficiency: {this.Efficiency}\n";
        }
    }
}
