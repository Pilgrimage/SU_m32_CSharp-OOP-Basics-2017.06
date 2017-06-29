using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<Person> persons = new List<Person>();

        var count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string[] input = Console.ReadLine().Split();
            int age = int.Parse(input[2]);
            double salary = double.Parse(input[3]);

            Person newPerson = new Person(input[0], input[1], age, salary);
            persons.Add(newPerson);
        }

        int bonus = int.Parse(Console.ReadLine());

        persons.OrderBy(p => p.FirstName)
            .ThenBy(p => p.Age)
            .ToList()
            .ForEach(p =>
            {
                p.IncreaseSalary(bonus);
                Console.WriteLine(p.ToString());
            });
    }

}
