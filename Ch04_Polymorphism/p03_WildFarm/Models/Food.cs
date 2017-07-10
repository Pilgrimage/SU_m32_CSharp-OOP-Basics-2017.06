namespace p03_WildFarm.Models
{
    public abstract class Food
    {
        protected Food(int qty)
        {
            this.Quantity = qty;
        }

        public int Quantity { get; set; }
    }
}
