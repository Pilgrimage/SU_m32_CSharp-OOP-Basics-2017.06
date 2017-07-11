using System;

public class Engine
{

    public void Run()
    {
        CarManager carManager = new CarManager();

        string input;
        string result;

        while ((input = Console.ReadLine()) != "Cops Are Here")
        {
            string[] inParam = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string command = inParam[0].ToLower();

            switch (command)
            {

                case "register":
                    // register {id} {type} {brand} {model} {year} {horsepower} {acceleration} {suspension} {durability}
                    // REGISTERS a car of the given type, with the given id, and the given stats.
                    // The car type will be either “Performance” or “Show”.
                    carManager.Register(int.Parse(inParam[1]), inParam[2], inParam[3], inParam[4], int.Parse(inParam[5]), int.Parse(inParam[6]), int.Parse(inParam[7]), int.Parse(inParam[8]), int.Parse(inParam[9]));
                    break;

                case "check":
                    // check { id}
                    // CHECKS details about the car with the given id.
                    // RETURNS a string representation of the car.
                    result = carManager.Check(int.Parse(inParam[1]));
                    Console.WriteLine(result);
                    break;

                case "open":
                    // open {id} {type} {length} {route} {prizePool}
                    // OPENS a race of the given type, with the given id, and stats.
                    // The race type will be either “Casual”, “Drag” or “Drift”.
                    if (inParam.Length == 6)
                    {
                        carManager.Open(int.Parse(inParam[1]), inParam[2], int.Parse(inParam[3]), inParam[4], int.Parse(inParam[5]));
                    }
                    else
                    {
                        carManager.Open(int.Parse(inParam[1]), inParam[2], int.Parse(inParam[3]), inParam[4], int.Parse(inParam[5]), int.Parse(inParam[6]));
                    }
                    break;

                case "participate":
                    // participate {carId} {raceId}
                    // ADDS a car as a participant in the given race.
                    // Once added, a car CANNOT turn down a race or be REMOVED from it.
                    carManager.Participate(int.Parse(inParam[1]), int.Parse(inParam[2]));
                    break;

                case "start":
                    // start {raceId}
                    // INITIATES the race with the given id. 
                    // RETURNS detailed information about the race result.
                    result = carManager.Start(int.Parse(inParam[1]));
                    Console.WriteLine(result);
                    break;

                case "park":
                    // park {carId}
                    // PARKS a car by a given id in the garage.
                    carManager.Park(int.Parse(inParam[1]));
                    break;

                case "unpark":
                    // unpark {carId}
                    // UNPARKS the car with the given id from the garage
                    carManager.Unpark(int.Parse(inParam[1]));
                    break;

                case "tune":
                    // tune {tuneIndex} {tuneAddOn}
                    // Tunes the currently parked CARS with the given index and the given add-on.
                    // You should increase a car’s horsepower by the given index, and the suspension, by HALF of the given index.
                    //     - 150 tuneIndex = 150 increase in the horsepower and 75 increase in suspension.
                    //     If the car is a ShowCar it should increase its stars by the given tuneIndex.
                    //     Upon tuning, a PerformanceCar adds the given add-on to its collection of add-ons.
                    carManager.Tune(int.Parse(inParam[1]), inParam[2]);
                    break;

                default:
                    Console.WriteLine("НЕМА такъв филм...");
                    break;
            }

        }

    }
}

