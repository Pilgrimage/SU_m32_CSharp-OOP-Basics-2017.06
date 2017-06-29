using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace p08_RawData
{
    public class RawData
    {
        public static void Main()
        {
            List<Car> autoPark = new List<Car>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Car newCar = new Car(input[0],
                                     int.Parse(input[1]), int.Parse(input[2]),
                                     int.Parse(input[3]), input[4],
                                     double.Parse(input[5]), int.Parse(input[6]),
                                     double.Parse(input[7]), int.Parse(input[8]),
                                     double.Parse(input[9]), int.Parse(input[10]),
                                     double.Parse(input[11]), int.Parse(input[12])
                                     );
                autoPark.Add(newCar);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                autoPark.Where(x => x.Cargo.Type == "fragile")
                        .Where(x => x.Tires.Any(a => a.Pressure < 1))
                        .ToList()
                        .ForEach(x => Console.WriteLine(x.Model));
            }
            else if (command == "flamable")
            {
                autoPark.Where(x => x.Cargo.Type == "flamable")
                        .Where(x => x.Engine.Power>250)
                        .ToList()
                        .ForEach(x => Console.WriteLine(x.Model));
            }

        }
    }
}
