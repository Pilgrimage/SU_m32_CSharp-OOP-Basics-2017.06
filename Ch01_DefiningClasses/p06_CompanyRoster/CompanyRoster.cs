using System.ComponentModel;
using System.Linq;

namespace p06_CompanyRoster
{
    using System;
    using System.Collections.Generic;

    public class CompanyRoster
    {
        public static void Main()
        {
            List<Employee> personal = new List<Employee>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string position = input[2];
                string department = input[3];
                string email;
                int age;
                switch (input.Length)
                {
                    case 4:
                        personal.Add(new Employee(name, salary, position, department));
                        break;

                    case 5:
                        if (int.TryParse(input[4], out age))
                        {
                            personal.Add(new Employee(name, salary, position, department, age));
                        }
                        else
                        {
                            email = input[4];
                            personal.Add(new Employee(name, salary, position, department, email));
                        }
                        break;

                    case 6:
                        email = input[4];
                        age = int.Parse(input[5]);
                        personal.Add(new Employee(name, salary, position, department, email, age));
                        break;
                }
            }

            var selected = personal
                .GroupBy(gr => gr.Department)
                .Select(x => new
                {
                    Department = x.Key,
                    AvgSalary = x.Average(s => s.Salary),
                    Employees = x.OrderByDescending(s => s.Salary)
                })
                .OrderByDescending(s => s.AvgSalary)
                .FirstOrDefault();

            
            Console.WriteLine($"Highest Average Salary: {selected.Department}");


            foreach (Employee emp in selected.Employees)
            {
                Console.WriteLine($"{emp.Name} {emp.Salary:f2} {emp.Email} {emp.Age}");
            }

        }
    }
}
