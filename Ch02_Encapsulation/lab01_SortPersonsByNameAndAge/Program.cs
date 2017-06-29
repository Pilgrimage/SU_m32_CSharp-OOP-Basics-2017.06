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
            Person newPerson = new Person(input[0], input[1], int.Parse(input[2]));
            persons.Add(newPerson);
        }

        persons.OrderBy(p => p.FirstName)
               .ThenBy(p => p.Age)
               .ToList()
               .ForEach(p => Console.WriteLine(p.ToString()));
    }
}
