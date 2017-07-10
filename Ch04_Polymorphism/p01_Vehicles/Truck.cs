namespace p01_Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelconsumptionInlitersPerKm) : base(fuelQuantity, fuelconsumptionInlitersPerKm)
        {
            this.FuelconsumptionInlitersPerKm += 1.6;
        }


        public override void ReFuel(double fuel)
        {
            base.FuelQuantity += fuel*0.95;
        }

    }
}
