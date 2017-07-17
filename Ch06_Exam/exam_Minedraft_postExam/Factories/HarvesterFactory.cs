using System.Collections.Generic;

public class HarvesterFactory
{
    public static Harvester GetHarvester(List<string> arguments)
    {
        string typeHarvester = arguments[0];
        string id = arguments[1];
        double oreOutput = double.Parse(arguments[2]);
        double energyRequirement = double.Parse(arguments[3]);

        switch (typeHarvester)
        {
            case "Hammer":
                return new HammerHarvester(id, oreOutput, energyRequirement);
            case "Sonic":
                int sonicFactor = int.Parse(arguments[4]);
                return new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
            default:
                return null;
        }
    }

}
