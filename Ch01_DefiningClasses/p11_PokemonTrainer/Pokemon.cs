namespace p11_PokemonTrainer
{
    public class Pokemon
    {
        private string namestr;
        private string element;
        private int health;

        public string Namestr
        {
            get { return this.namestr; }
            set { this.namestr = value; }
        }

        public string Element
        {
            get { return this.element; }
            set { this.element = value; }
        }


        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public Pokemon(string namestr, string element, int health)
        {
            this.Namestr = namestr;
            this.Element = element;
            this.Health = health;
        }
    }
}
