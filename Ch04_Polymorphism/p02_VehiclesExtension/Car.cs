namespace p02_VehiclesExtension
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelconsumptionInlitersPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelconsumptionInlitersPerKm, tankCapacity)
        {
            this.FuelconsumptionInlitersPerKm += 0.9;
        }
    }

}
