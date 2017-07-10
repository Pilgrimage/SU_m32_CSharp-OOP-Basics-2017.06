namespace p03_WildFarm.Models.Animals
{
    using System;

    public class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, string livingRegion)
            : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "SQUEEEAAAK!";
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name!="Vegetable")
            {
                throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");
            }
            base.FoodEaten += food.Quantity;
        }

    }
}
