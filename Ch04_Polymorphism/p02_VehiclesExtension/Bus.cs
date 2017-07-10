namespace p02_VehiclesExtension
{
    using System;

    public class Bus : Vehicle
    {
        
        public Bus(double fuelQuantity, double fuelconsumptionInlitersPerKm, double tankCapacity)
            : base(fuelQuantity, fuelconsumptionInlitersPerKm, tankCapacity)
        {
            this.EmptyBus = false;
        }

        public bool EmptyBus { get; set; }

        public override string DriveDistance(double distance)
        {
            double conditioner = EmptyBus ? 0 : 1.4;
            double neededFuel = distance * (this.FuelconsumptionInlitersPerKm + conditioner);
            this.EmptyBus = false;
            if (this.FuelQuantity < neededFuel)
            {
                throw new ArgumentException($"{GetType().Name} needs refueling");
            }
            this.FuelQuantity -= neededFuel;
            return $"{GetType().Name} travelled {distance} km";
        }
    }
}
