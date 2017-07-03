using System;
using System.Collections.Generic;
using System.Linq;

namespace p11_PokemonTrainer
{
    public class PokemonTrainer
    {
        public static void Main()
        {
            List<Trainer> trainers = new List<Trainer>();

            string input;

            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] inputArg = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                Pokemon newPokemon = new Pokemon(inputArg[1], inputArg[2],int.Parse(inputArg[3]));
                Trainer trainer = trainers.FirstOrDefault(n => n.Name == inputArg[0]);
                if (trainer==null)
                {
                    trainers.Add(new Trainer(inputArg[0]));
                    trainer = trainers.FirstOrDefault(n => n.Name == inputArg[0]);
                }
                trainer.Pokemons.Add(newPokemon);
            }


            while ((input = Console.ReadLine()) != "End")
            {
                trainers.ForEach(x=>x.CheckForElement(input));
            }

            foreach (var trainer in trainers.OrderByDescending(x=>x.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
