public class HammerHarvester : Harvester
{

    public HammerHarvester(string id, double oreOutput, double energyRequirement) 
        : base(id, oreOutput, energyRequirement)
    {
        base.OreOutput = base.OreOutput * 3;
        base.EnergyRequirement = base.EnergyRequirement * 2;
    }

}
