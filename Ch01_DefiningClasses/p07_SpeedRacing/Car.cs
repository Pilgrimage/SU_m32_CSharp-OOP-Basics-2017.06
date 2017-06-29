namespace p07_SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionFor1km;
        private int distanceTraveled;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public double FuelConsumptionFor1km
        {
            get { return this.fuelConsumptionFor1km; }
            set { this.fuelConsumptionFor1km = value; }
        }

        public int DistanceTraveled
        {
            get { return this.distanceTraveled; }
            set { this.distanceTraveled = value; }
        }

        public Car(string model, double fuelAmount, double fuelConsumptionFor1Km)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionFor1km = fuelConsumptionFor1Km;
            this.distanceTraveled = 0;
        }

        public bool DriveDistance(int distance)
        {
            double needFuel = this.FuelConsumptionFor1km * distance;
            if (needFuel > this.FuelAmount)
            {
                return false;
            }
            this.DistanceTraveled += distance;
            this.FuelAmount -= needFuel;
            return true;
        }
    }
}
