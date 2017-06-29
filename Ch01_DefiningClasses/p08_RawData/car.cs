namespace p08_RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;

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

        public Cargo Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }

        public Tire[] Tires
        {
            get { return this.tires; }
            set { this.tires = value; }
        }

        public Car(string model,
            int engineSpeed, int enginePower,
            int cargoWeight, string cargoType,
            double tirePress1, int tireAge1, double tirePress2, int tireAge2,
            double tirePress3, int tireAge3, double tirePress4, int tireAge4)
        {
            this.Model = model;

            this.Engine = new Engine(engineSpeed, enginePower);

            this.Cargo = new Cargo(cargoWeight, cargoType);

            this.Tires = new Tire[4]
            {
                new Tire(tirePress1, tireAge1),
                new Tire(tirePress2, tireAge2),
                new Tire(tirePress3, tireAge3),
                new Tire(tirePress4, tireAge4)
            };
        }
    }
}
