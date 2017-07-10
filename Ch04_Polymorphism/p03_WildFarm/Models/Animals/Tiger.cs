namespace p03_WildFarm.Models.Animals
{
    using System;

    public class Tiger : Felime
    {
        public Tiger(string animalName, string animalType, double animalWeight, string livingRegion)
            : base(animalName, animalType, animalWeight, livingRegion)
        {
        }
        
        public override string MakeSound()
        {
            return "ROAAR!!!";
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");
            }
            base.FoodEaten += food.Quantity;
        }

    }
}
