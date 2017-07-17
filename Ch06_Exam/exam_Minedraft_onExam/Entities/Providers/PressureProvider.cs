using System.Text;

class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput) 
        : base(id, energyOutput)
    {
        this.EnergyOutput = base.EnergyOutput * 1.5;
    }


    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Pressure Provider – {this.Id}");
        sb.AppendLine($"Energy Output: {this.EnergyOutput}");
        return sb.ToString().Trim();
    }

}
