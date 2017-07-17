using System;
using System.Text;

public abstract class Provider
{
    private string id;
    private double energyOutput;

    public Provider(string id, double energyOutput)
    {
        this.id = id;
        this.EnergyOutput = energyOutput;
    }

    public string Id
    {
        get { return this.id; }
    }

    public double EnergyOutput
    {
        get { return this.energyOutput; }
        protected set
        {
            if (value <= 0 || value > 10000)
            {
                throw new ArgumentException($"Provider is not registered, because of it's {nameof(EnergyOutput)}");
            }
            this.energyOutput = value;
        }
    }


    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.GetType().Name} Provider – {this.Id}");
        sb.AppendLine($"Energy Output: {this.EnergyOutput}");
        return sb.ToString().Trim();
    }

}
