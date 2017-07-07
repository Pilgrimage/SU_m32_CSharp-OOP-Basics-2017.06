namespace p05_MordorsCrueltyPlan.Factory.MoodModels
{
    public abstract class Mood
    {
        private string type;

        public Mood(string type)
        {
            this.Type = type;
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public override string ToString()
        {
            return $"{GetType().Name}";
        }

    }
}
