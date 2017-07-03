using System;
using System.Collections.Generic;
using System.Linq;

namespace p10_CarSalesman
{
    public class CarSalesman
    {
        public static void Main()
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            int countEngines = int.Parse(Console.ReadLine());
            for (int i = 0; i < countEngines; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int power = int.Parse(input[1]);
                switch (input.Length)
                {
                    case 2:
                        engines.Add(new Engine(model, power));
                        break;
                    case 3:
                        int displ;
                        if (int.TryParse(input[2], out displ))
                        {
                            engines.Add(new Engine(model, power, displ));
                        }
                        else
                        {
                            engines.Add(new Engine(model, power, input[2]));
                        }
                        break;
                    case 4:
                        int displacements = int.Parse(input[2]);
                        string efficiency = input[3];
                        engines.Add(new Engine(model, power, displacements, efficiency));
                        break;
                }
            }

            int countCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < countCars; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string carModel = input[0];
                string carEngineModel = input[1];
                Engine carEngine = engines.FirstOrDefault(m => m.Model == carEngineModel);
                if (carEngine == null)
                {
                    continue;
                }

                switch (input.Length)
                {
                    case 2:
                        cars.Add(new Car(carModel, carEngine));
                        break;
                    case 3:
                        int weight;
                        if (int.TryParse(input[2], out weight))
                        {
                            cars.Add(new Car(carModel, carEngine, weight));
                        }
                        else
                        {
                            cars.Add(new Car(carModel, carEngine, input[2]));
                        }
                        break;
                    case 4:
                        cars.Add(new Car(carModel, carEngine, int.Parse(input[2]), input[3]));
                        break;
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }

        }
    }
}
