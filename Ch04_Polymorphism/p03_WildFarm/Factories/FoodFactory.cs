namespace p03_WildFarm.Factories
{
    using p03_WildFarm.Models;
    using p03_WildFarm.Models.Foods;

    public class FoodFactory
    {
        public static Food GetFood(string[] foodParams)
        {
            var foodType = foodParams[0];
            var foodQuantity = int.Parse(foodParams[1]);

            if (foodType == "Meat")
            {
                return new Meat(foodQuantity);
            }

            return new Vegetable(foodQuantity);
        }
    }
}
