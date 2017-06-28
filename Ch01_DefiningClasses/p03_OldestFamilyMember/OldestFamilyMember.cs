using System.Collections.Generic;
using System.Linq;

namespace p03_OldestFamilyMember
{
    using System;
    using System.Reflection;

    public class OldestFamilyMember
    {
        public static void Main()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            Family family = new Family();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();

                Person person = new Person(int.Parse(input[1]), input[0]);
                family.AddMember(person);
            }

            Person oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.name} {oldest.age}");
        }
    }


    public class Person
    {
        public string name;
        public int age;

        public Person() : this(1, "No name")
        {
        }

        public Person(int age) : this(age, "No name")
        {
        }

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
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
            return Peoples.OrderByDescending(x => x.age).FirstOrDefault();
        }
    }
}
