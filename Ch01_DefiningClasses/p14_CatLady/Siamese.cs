namespace p14_CatLady
{
    public class Siamese : Cat
    {
        private int earSize;

        public Siamese(string name, int size) : base(name)
        {
            this.EarSize = size;
        }

        public int EarSize
        {
            get { return this.earSize; }
            protected set { this.earSize = value; }
        }

        public override string ToString()
        {
            return $"Siamese {base.Name} {this.EarSize}";
        }
    }
}
