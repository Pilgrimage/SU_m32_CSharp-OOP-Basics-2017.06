using System.Collections.Generic;

public class ProviderFactory
{
    public static Provider GetProvider(List<string> arguments)
    {
        string typeProvider = arguments[0];
        string id = arguments[1];
        double energyOutput = double.Parse(arguments[2]);

        switch (typeProvider)
        {
            case "Solar":
                return new SolarProvider(id, energyOutput);
            case "Pressure":
                return new PressureProvider(id, energyOutput);
            default:
                return null;
        }
    }

}
