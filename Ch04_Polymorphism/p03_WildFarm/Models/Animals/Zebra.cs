namespace p03_WildFarm.Models.Animals
{
    using System;

    public class Zebra : Mammal
    {
        public Zebra(string animalName, string animalType, double animalWeight, string livingRegion)
            : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "Zs";
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Vegetable")
            {
                throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");
            }
            this.FoodEaten += food.Quantity;
        }

    }
}
