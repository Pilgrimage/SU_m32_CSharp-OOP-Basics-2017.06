namespace p03_WildFarm.Models
{
    public abstract class Animal
    {
        protected Animal(string animalName, string animalType, double animalWeight)
        {
            this.AnimalName = animalName;
            this.AnimalType = animalType;
            this.AnimalWeight = animalWeight;
            this.FoodEaten = 0;
        }

        public int FoodEaten { get; set; }
        public string AnimalName { get; protected set; }
        public string AnimalType { get; protected set; }
        public double AnimalWeight { get; protected set; }

        public abstract string MakeSound();

        public abstract void Eat(Food food);

        public override string ToString()
        {
            return "";
        }
    }
}
