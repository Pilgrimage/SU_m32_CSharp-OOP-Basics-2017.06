namespace p02_VehiclesExtension
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] inputCar = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] inputTruck = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] inputBus = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Car car = new Car(double.Parse(inputCar[1]), double.Parse(inputCar[2]), double.Parse(inputCar[3]));
            Truck truck = new Truck(double.Parse(inputTruck[1]), double.Parse(inputTruck[2]), double.Parse(inputCar[3]));
            Bus bus = new Bus(double.Parse(inputBus[1]), double.Parse(inputBus[2]), double.Parse(inputBus[3]));

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                double comParam = double.Parse(command[2]);

                try
                {
                    if (command[1].ToLower() == "car")
                    {
                        ExecuteCommand(car, command[0], comParam);
                    }
                    else if (command[1].ToLower() == "truck")
                    {
                        ExecuteCommand(truck, command[0], comParam);
                    }
                    else if (command[1].ToLower() == "bus")
                    {
                        if (command[0].ToLower()=="driveempty")
                        {
                            bus.EmptyBus = true;
                        }
                        ExecuteCommand(bus, command[0], comParam);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            
            Console.WriteLine($"{car}\n{truck}\n{bus}");
        }

        private static void ExecuteCommand(Vehicle vehicle, string command, double parameter)
        {
            switch (command.ToLower())
            {
                case "drive":
                case "driveempty":
                    string result = vehicle.DriveDistance(parameter);
                    Console.WriteLine(result);
                    break;
                case "refuel":
                    vehicle.ReFuel(parameter);
                    break;
            }
        }
    }
}
