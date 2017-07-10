namespace p03_WildFarm.Models.Animals
{
    public class Cat : Felime
    {
        private string breed;
        
        public Cat(string animalName, string animalType, double animalWeight, string livingRegion, string breed)
            : base(animalName, animalType, animalWeight, livingRegion)
        {
            this.breed = breed;
        }


        public override string MakeSound()
        {
            return "Meowwww";
        }

        public override void Eat(Food food)
        {
            base.FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}[{this.AnimalName}, {this.breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
