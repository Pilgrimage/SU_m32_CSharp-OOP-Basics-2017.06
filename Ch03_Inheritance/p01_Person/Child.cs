namespace p01_Person
{
    using System;

    public class Child : Person
    {

        public Child(string name, int age) : base(name, age)
        {
            base.Name = name;
            this.Age = age;
        }

        public override int Age
        {
            get { return base.Age; }
            protected set
            {
                if (value >= 15)
                {
                    throw new ArgumentException("Child's age must be less than 15!");
                }
                base.Age = value;
            }
        }

    }
}
