namespace p07_SpeedRacing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SpeedRacing
    {
        public static void Main()
        {
            List<Car> autoPark = new List<Car>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] inputCar = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = inputCar[0];
                double fuel = double.Parse(inputCar[1]);
                double consumtion = double.Parse(inputCar[2]);

                autoPark.Add(new Car(name, fuel, consumtion));
            }

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputDrive = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (inputDrive[0] != "Drive")
                {
                    continue;
                }
                string model = inputDrive[1];
                int amountOfKm = int.Parse(inputDrive[2]);

                if (!autoPark.FirstOrDefault(x => x.Model == model).DriveDistance(amountOfKm))   // non-static method
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

            }
            
            foreach (Car car in autoPark)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled}");
            }
        }
    }
}
