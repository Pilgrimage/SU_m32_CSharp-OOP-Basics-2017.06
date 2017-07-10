using System;

namespace p01_Vehicles
{
    public class StartUp
    {
        public static void Main()
        {
            string[] inputCar = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] inputTruck = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Car car = new Car(double.Parse(inputCar[1]), double.Parse(inputCar[2]));
            Truck truck = new Truck(double.Parse(inputTruck[1]), double.Parse(inputTruck[2]));

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                double comParam = double.Parse(command[2]);

                try
                {

                    switch (command[0].ToLower())
                    {
                        case "drive":
                            if (command[1].ToLower() == "car")
                            {
                                Console.WriteLine(car.DriveDistance(comParam));
                            }
                            else if (command[1].ToLower() == "truck")
                            {
                                Console.WriteLine(truck.DriveDistance(comParam));
                            }
                            break;

                        case "refuel":
                            if (command[1].ToLower() == "car")
                            {
                                car.ReFuel(comParam);
                            }
                            else if (command[1].ToLower() == "truck")
                            {
                                truck.ReFuel(comParam);
                            }
                            break;

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }


            Console.WriteLine($"{car}\n{truck}");

        }
    }
}
