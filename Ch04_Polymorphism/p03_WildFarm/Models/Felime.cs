namespace p03_WildFarm.Models
{
    public abstract class Felime : Mammal
    {
        public Felime(string animalName, string animalType, double animalWeight, string livingRegion)
            : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

    }
}
