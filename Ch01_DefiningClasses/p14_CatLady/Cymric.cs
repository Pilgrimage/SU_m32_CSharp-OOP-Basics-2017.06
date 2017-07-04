namespace p14_CatLady
{
    public class Cymric : Cat
    {
        private double furLength;

        public Cymric(string name, double length) : base(name)
        {
            this.FurLength = length;
        }

        public double FurLength
        {
            get { return this.furLength; }
            protected set { this.furLength = value; }
        }

        public override string ToString()
        {
            return $"Cymric {base.Name} {this.FurLength:f2}";
        }

    }
}
