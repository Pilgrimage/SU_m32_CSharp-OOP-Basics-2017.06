using System.Text;

public class HammerHarvester : Harvester
{

    public HammerHarvester(string id, double oreOutput, double energyRequirement) 
        : base(id, oreOutput, energyRequirement)
    {
        base.OreOutput = base.OreOutput * 3;
        base.EnergyRequirement = base.EnergyRequirement * 2;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Hammer Harvester - {this.Id}");
        sb.AppendLine($"Ore Output: {this.OreOutput}");
        sb.AppendLine($"Energy Requirement: {this.EnergyRequirement}");
        return sb.ToString().Trim();
    }

}
