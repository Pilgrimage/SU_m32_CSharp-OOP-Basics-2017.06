using System.Linq;
using System.Collections.Generic;

public class Garage
{
    private List<Car> parkedCars;

    public Garage()
    {
        this.ParkedCars = new List<Car>();
    }

    public List<Car> ParkedCars
    {
        get { return this.parkedCars; }
        set { this.parkedCars = value; }
    }

    public void ParkCar(Car car)
    {
        if (car != null)
        {
            ParkedCars.Add(car);
        }
    }
    public void UnparkCar(Car car)
    {
        if (car != null && ParkedCars.Any(x => x.Equals(car)))
        {
            ParkedCars.Remove(car);
        }
    }

}
