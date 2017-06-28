namespace p01_DefineClassPerson
{
    using System;
    using System.Reflection;

    public class DefineClassPerson
    {
        public static void Main()
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

            Person firstPerson = new Person();
            firstPerson.name = "Pesho";
            firstPerson.age = 20;

            Person secondPerson = new Person()
            {
                name = "Gosho",
                age = 18
            };

            Person thirdPerson = new Person()
            {
                name = "Stamat",
                age = 43
            };
        }
    }


    public class Person
    {
        public string name;
        public int age;
    }
}
