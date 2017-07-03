using System;
using System.Collections.Generic;
using System.Linq;

namespace p11_PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int NumberOfBadges
        {
            get { return this.numberOfBadges; }
            set { this.numberOfBadges = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }

        public Trainer(string name)
        {
            this.name = name;
            this.numberOfBadges = 0;
            this.pokemons = new List<Pokemon>();
        }

        public void CheckForElement(string elem)
        {
            List<Pokemon> result = this.Pokemons.Where(e => e.Element == elem).ToList();

            if (this.Pokemons.Any(e => e.Element == elem))
            {
                this.NumberOfBadges += 1;
            }
            else
            {
                foreach (var pokemon in Pokemons)
                {
                    pokemon.Health -= 10;
                }
                DeleteInvalidPokemons();
            }
        }

        public void DeleteInvalidPokemons()
        {
            this.Pokemons.RemoveAll(x => x.Health <= 0);
        }
    }
}
