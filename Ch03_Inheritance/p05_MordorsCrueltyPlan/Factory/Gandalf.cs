namespace p05_MordorsCrueltyPlan.Factory
{
    using System.Collections.Generic;
    using System.Linq;
    using FoodModels;
    using MoodModels;

    public class Gandalf
    {
        private List<Food> foods;
        private Mood mood;
        MoodFactory moodF = new MoodFactory();
        private int points;

        public Gandalf(List<Food> foods)
        {
            this.Foods = foods;
            this.points = this.GetPoints(this.Foods);
            this.mood = moodF.GetMood(this.points);
        }

        private List<Food> Foods
        {
            get { return this.foods; }
            set { this.foods = value; }
        }

        private int GetPoints(List<Food> foods)
        {
            return foods.Sum(t => t.Happiness);
        }

        public override string ToString()
        {
            return $"{this.points}\n{this.mood.Type}";
        }

    }
}
