namespace p12_Google
{
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private Company company;
        private Car car;
        private List<Pokemon> pokemons;
        private List<Parent> parents;
        private List<Child> children;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Company Company
        {
            get { return this.company; }
            set { this.company = value; }
        }

        public Car Car
        {
            get { return this.car; }
            set { this.car = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }

        public List<Parent> Parents
        {
            get { return this.parents; }
            set { this.parents = value; }
        }

        public List<Child> Children
        {
            get { return this.children; }
            set { this.children = value; }
        }

        public Person(string name)
        {
            this.Name = name;
            this.Pokemons = new List<Pokemon>();
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
        }

        public override string ToString()
        {
            string companyToStr = this.Company != null ? this.Company.ToString() : "";
            string carToStr = this.Car != null ? this.Car.ToString() : "";
            string pokemonsToStr = this.Pokemons.Count > 0 ? string.Join("", this.Pokemons) : "";
            string parentsToStr = this.Parents.Count > 0 ? string.Join("", this.Parents) : "";
            string childrenToStr = this.Children.Count > 0 ? string.Join("", this.Children) : "";

            return $"{this.Name}\nCompany:\n{companyToStr}Car:\n{carToStr}Pokemon:\n{pokemonsToStr}Parents:\n{parentsToStr}Children:\n{childrenToStr}"
            ;
        }
    }
}
