using System;
using System.Collections.Generic;
using System.Linq;

namespace p12_Google
{
    public class Google
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();

            string input;

            while ((input=Console.ReadLine())!="End")
            {
                string[] inArg = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string name = inArg[0];
                if (!people.Any(n=>n.Name==name))
                {
                    people.Add(new Person(name));
                }
                Person person = people.FirstOrDefault(n => n.Name == name);
                string category = inArg[1];

                switch (category)
                {
                    case "company":
                        Company newCompany = new Company(inArg[2], inArg[3], decimal.Parse(inArg[4]));
                        person.Company = newCompany;
                        break;

                    case "car":
                        Car newCar = new Car(inArg[2], int.Parse(inArg[3]));
                        person.Car = newCar;
                        break;

                    case "pokemon":
                        Pokemon newPokemon = new Pokemon(inArg[2], inArg[3]);
                        person.Pokemons.Add(newPokemon);
                        break;

                    case "parents":
                        Parent newParent = new Parent(inArg[2], inArg[3]);
                        person.Parents.Add(newParent);
                        break;

                    case "children":
                        Child newChild = new Child(inArg[2], inArg[3]);
                        person.Children.Add(newChild);
                        break;
                }
            }

            string targetName = Console.ReadLine().Trim();
            Person targetPerson = people.FirstOrDefault(n => n.Name == targetName);

            Console.Write(targetPerson.ToString());
        }
    }
}
