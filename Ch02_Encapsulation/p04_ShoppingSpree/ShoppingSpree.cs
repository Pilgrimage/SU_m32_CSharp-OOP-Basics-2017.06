namespace p04_ShoppingSpree
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class ShoppingSpree
    {
        public static void Main()
        {
            List<Product> products = new List<Product>();
            List<Person> persons = new List<Person>();

            // Customers
            string[] inputPersons = Console.ReadLine().Split(new char[] { ';'}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < inputPersons.Length; i++)
            {
                string[] personParams = inputPersons[i].Split('=');
                string name = personParams[0];
                decimal money = decimal.Parse(personParams[1]);

                try
                {
                    persons.Add(new Person(name, money));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            // Load the products
            string[] inputProducts = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < inputProducts.Length; i++)
            {
                string[] productParams = inputProducts[i].Split('=');
                string name = productParams[0];
                decimal cost = decimal.Parse(productParams[1]);

                try
                {
                    products.Add(new Product(name, cost));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            string input;

            // Go to shopping
            while ((input=Console.ReadLine())!="END")
            {
                string[] buy = input.Split();
                Person customer = persons.FirstOrDefault(n => n.Name == buy[0]);
                Product prod = products.FirstOrDefault(n => n.Name == buy[1]);

                try
                {
                    customer.BuyProduct(prod);
                    Console.WriteLine($"{customer.Name} bought {prod.Name}");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            
            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
