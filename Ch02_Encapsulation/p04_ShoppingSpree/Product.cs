namespace p04_ShoppingSpree
{
    using System;

    public class Product
    {
        private string name;
        private decimal cost;

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(Name)} cannot be an empty string");
                }
                this.name = value;
            }
        }

        public decimal Cost
        {
            get { return this.cost; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Money cannot be negative");
                }
                this.cost = value;
            }
        }

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

    }
}
