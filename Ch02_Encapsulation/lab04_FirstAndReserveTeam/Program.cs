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

        Team beroe = new Team("Beroe");

        persons.ForEach(x=>beroe.AddPlayer(x));

        Console.WriteLine($"First team have {beroe.FirstTeam.Count} players");
        Console.WriteLine($"Reserve team have {beroe.ReserveTeam.Count} players");
    }
}

