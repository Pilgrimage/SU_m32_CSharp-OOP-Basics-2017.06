namespace p05_MordorsCrueltyPlan
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Factory;
    using Factory.FoodModels;

    public class StartUp
    {
        public static void Main()
        {
            FoodFactory foodF = new FoodFactory();

            var foodInput = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower())
                .ToList();

            List<Food> foods = foodInput.Select(x => foodF.CreateFood(x)).ToList();

            Gandalf gandy = new Gandalf(foods);

            Console.WriteLine(gandy);
        }
    }
}
