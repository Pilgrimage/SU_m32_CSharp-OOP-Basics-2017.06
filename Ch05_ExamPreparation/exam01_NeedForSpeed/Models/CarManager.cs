using System;
using System.Runtime.Remoting.Messaging;
using System.Linq;
using System.Collections.Generic;

public class CarManager
{
    private Dictionary<int, Car> cars = new Dictionary<int, Car>();
    private Dictionary<int, Race> races = new Dictionary<int, Race>();
    private Garage garage = new Garage();

    private List<int> participateCars = new List<int>();
    private List<int> parkedCars = new List<int>();


    // Register Car i championat - DONE
    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {
        Car newCar = CarFactory.GetCar(type, brand, model, yearOfProduction, horsepower, acceleration, suspension,
            durability);
        if (newCar != null)
        {
            this.cars.Add(id, CarFactory.GetCar(type, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability));
        }
    }

    // Return info for a car - DONE
    public string Check(int id)
    {
        return this.cars[id].ToString();
    }

    // Register racinig - DONE
    public void Open(int id, string type, int length, string route, int prizePool)
    {
        Race newRace = RaceFactory.GetRace(type, length, route, prizePool);
        if (newRace != null)
        {
            races.Add(id, newRace);
        }
    }

    // Participate in a race - DONE
    public void Participate(int carId, int raceId)
    {
        Race race = this.races[raceId];
        Car car = this.cars[carId];
        if (!garage.ParkedCars.Contains(car))
        {
            race.Participants.Add(car);
            this.participateCars.Add(carId);
        }
    }


    // Start and Ends a Race...
    public string Start(int id)
    {
        Race race = races[id];
        if (race.Participants.Count == 0)
        {
            return "Cannot start the race with zero participants.";
        }

        string result = race.ToString();

        foreach (Car c in race.Participants)
        {
            var k = cars.FirstOrDefault(x => x.Value == c).Key;
            participateCars.Remove(k);
        }
        races.Remove(id);
        return result;
    }


    // Park the car, if don't participate in race - DONE
    public void Park(int id)
    {
        Car car = this.cars[id];
        if (!participateCars.Contains(id))
        {
            this.garage.ParkedCars.Add(car);
            this.parkedCars.Add(id);
        }
    }

    // Unpark car - DONE
    public void Unpark(int id)
    {
        Car car = this.cars[id];
        if (parkedCars.Contains(id))
        {
            this.garage.ParkedCars.Remove(car);
            this.parkedCars.Remove(id);
        }
    }

    // TuneUp - DONE
    public void Tune(int tuneIndex, string addOn)
    {
        foreach (Car pCar in garage.ParkedCars)
        {
            pCar.TuneUp(tuneIndex, addOn);
        }
    }

}
