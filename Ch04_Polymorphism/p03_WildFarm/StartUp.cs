namespace p03_WildFarm
{
    using System;
    using p03_WildFarm.Factories;
    using p03_WildFarm.Models;

    public class StartUp
    {
        public static void Main()
        {
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] animalParams = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Animal animal = AnimalFactory.GetAnimal(animalParams);

                string[] foodParams = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Food food = FoodFactory.GetFood(foodParams);

                Console.WriteLine(animal.MakeSound());

                try
                {
                    animal.Eat(food);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine(animal);
            }

        }
    }
}
