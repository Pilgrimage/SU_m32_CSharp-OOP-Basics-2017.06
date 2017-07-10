namespace p03_WildFarm.Factories
{
    using p03_WildFarm.Models;
    using p03_WildFarm.Models.Animals;

    public class AnimalFactory
    {

        public static Animal GetAnimal(string[] animalParams)
        {
            var animalType = animalParams[0];
            var animalName = animalParams[1];
            var animalWeight = double.Parse(animalParams[2]);
            var animalRegion = animalParams[3];

            switch (animalType)
            {
                case "Mouse":
                    return new Mouse(animalName, animalType, animalWeight, animalRegion);
                case "Zebra":
                    return new Zebra(animalName, animalType, animalWeight, animalRegion);
                case "Cat":
                    return new Cat(animalName, animalType, animalWeight, animalRegion, animalParams[4]);
                case "Tiger":
                    return new Tiger(animalName, animalType, animalWeight, animalRegion);
                default:
                    return null;
            }
        }


    }
}
