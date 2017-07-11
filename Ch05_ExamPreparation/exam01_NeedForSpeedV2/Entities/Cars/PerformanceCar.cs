using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PerformanceCar : Car
{
    private List<string> addOns;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.AddOns = new List<string>();
        this.Horsepower += (base.Horsepower * 50) / 100;
        this.Suspension -= (base.Suspension * 25) / 100;
    }
    
    public List<string> AddOns
    {
        get { return this.addOns; }
        set { this.addOns = value; }
    }
    
    public override void TuneUp(int tuneIndex, string addOn)
    {
        base.TuneUp(tuneIndex, addOn);
        this.AddOns.Add(addOn);
    }
    
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(base.ToString());
        sb.AppendLine($"Add-ons: {(this.AddOns.Any() ? $"{string.Join(", ", this.AddOns)}" : "None")}");

        return sb.ToString().Trim();
    }
}
