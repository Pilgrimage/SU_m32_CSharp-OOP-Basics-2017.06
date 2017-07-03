namespace p10_CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;


        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public Car(string model, Engine engine, int weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public Car(string model, Engine engine) : this(model, engine, 0, "n/a")
        {
        }

        public Car(string model, Engine engine, int weight) : this(model, engine, weight, "n/a")
        {
        }
        public Car(string model, Engine engine, string color) : this(model, engine, 0, color)
        {
        }

        public override string ToString()
        {
            string weghtStr = this.Weight == 0 ? "n/a" : this.Weight.ToString();
            return $"{this.Model}:\n{Engine}  Weight: {weghtStr}\n  Color: {this.Color}";
        }

    }
}
