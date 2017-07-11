using System;
using System.Linq;
using System.Collections.Generic;

public class CarManager
{
    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> races;
    private Garage garage;

    public CarManager()
    {
        this.cars = new Dictionary<int, Car>();
        this.races = new Dictionary<int, Race>();
        this.garage = new Garage();
    }


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

    // Register racinig - DONE (bonus)
    public void Open(int id, string type, int length, string route, int prizePool, int someParam)
    {
        Race newRace = RaceFactory.GetRace(type, length, route, prizePool, someParam);
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

        races.Remove(id);
        return result;
    }


    // Park the car, if don't participate in race - DONE
    public void Park(int id)
    {
        Car car = this.cars[id];
        if (!IsParticipate(car))
        {
            this.garage.ParkedCars.Add(car);
        }
    }

    // Unpark car - DONE
    public void Unpark(int id)
    {
        Car car = this.cars[id];
        if (garage.ParkedCars.Contains(car))
        {
            this.garage.ParkedCars.Remove(car);
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

    private bool IsParticipate(Car car)
    {
        foreach (Race race in races.Values)
        {
            if (race.Participants.Contains(car))
            {
                return true;
            };
        }
        return false;
    }

}
