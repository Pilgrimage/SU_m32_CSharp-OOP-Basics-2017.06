namespace p14_CatLady
{
    public class Cat
    {
        private string name;

        public Cat(string name)
        {
            this.Name = name;
        }
        public  string Name
        {
            get { return this.name; }
            protected set { this.name = value; }
        }
    }
}
