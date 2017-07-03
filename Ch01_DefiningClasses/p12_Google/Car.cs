namespace p12_Google
{
    public class Car
    {
        private string model;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        private int speed;

        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public Car(string model, int speed)
        {
            this.Model = model;
            this.Speed = speed;
        }

        public override string ToString()
        {
            return $"{this.Model} {this.Speed}\n";
        }
    }
}
