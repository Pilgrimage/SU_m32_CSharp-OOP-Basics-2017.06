namespace p02_VehiclesExtension
{
    using System;

    public abstract class Vehicle
    {
        private double tankCapacity;
        private double fuelQuantity;
        private double fuelconsumptionInlitersPerKm;

        public Vehicle(double fuelQuantity, double fuelconsumptionInlitersPerKm, double tankCapacity)
        {
            this.tankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelconsumptionInlitersPerKm = fuelconsumptionInlitersPerKm;
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }
                this.fuelQuantity = value;
            }
        }

        public double FuelconsumptionInlitersPerKm
        {
            get { return this.fuelconsumptionInlitersPerKm; }
            set { this.fuelconsumptionInlitersPerKm = value; }
        }



        public virtual void ReFuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if ((this.tankCapacity - FuelQuantity) < fuel)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }
            this.FuelQuantity += fuel;
        }

        public virtual string DriveDistance(double distance)
        {
            double neededFuel = distance * this.FuelconsumptionInlitersPerKm;
            if (this.FuelQuantity < neededFuel)
            {
                throw new OperationCanceledException($"{GetType().Name} needs refueling");
            }
            this.FuelQuantity -= neededFuel;
            return $"{GetType().Name} travelled {distance} km";
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
