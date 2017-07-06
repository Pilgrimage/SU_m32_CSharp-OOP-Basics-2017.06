namespace p06_Animals
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input;

            while ((input = Console.ReadLine()) != "Beast!")
            {
                string type = input;

                string[] inParams = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    string name = inParams[0];
                    int age;
                    if (!int.TryParse(inParams[1], out age))
                    {
                        throw new ArgumentException("Invalid input!");
                    }

                    switch (type.ToLower())
                    {
                        case "dog":
                            Console.WriteLine(new Dog(name, age, inParams[2]));
                            break;

                        case "frog":
                            Console.WriteLine(new Frog(name, age, inParams[2]));
                            break;

                        case "cat":
                            Console.WriteLine(new Cat(name, age, inParams[2]));
                            break;

                        case "kitten":
                            Console.WriteLine(new Kitten(name, age));
                            break;

                        case "tomcat":
                            Console.WriteLine(new Tomcat(name, age));
                            break;

                        default:
                            throw new ArgumentException("Invalid input!");
                            break;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

        }
    }
}
