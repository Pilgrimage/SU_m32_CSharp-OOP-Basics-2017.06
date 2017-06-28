namespace p04_OpinionPoll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OpinionPoll
    {
        public static void Main()
        {
            Family family = new Family();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();

                Person person = new Person(int.Parse(input[1]), input[0]);
                family.AddMember(person);
            }

            foreach (Person person in family.SelectedPersons())
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }


    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Person() : this(1, "No name")
        {
        }

        public Person(int age) : this(age, "No name")
        {
        }

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
    }



    public class Family
    {
        private List<Person> people;

        public Family()
        {
            Peoples = new List<Person>();
        }
        public List<Person> Peoples
        {
            get { return this.people; }
            set { this.people = value; }
        }

        public void AddMember(Person member)
        {
            this.Peoples.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.Peoples.OrderByDescending(x => x.Age).FirstOrDefault();
        }

        public List<Person> SelectedPersons()
        {
            return this.Peoples.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
        }
    }

}
