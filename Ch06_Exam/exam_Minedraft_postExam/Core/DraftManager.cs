using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private string mode;
    private double savedEnergy;
    private double totalOre;
    private List<Harvester> harvesters;
    private List<Provider> providers;

    public DraftManager()
    {
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();

        this.mode = "Full";
        this.savedEnergy = 0;
        this.totalOre = 0;
    }

    public List<Harvester> Harvesters
    {
        get { return this.harvesters; }
        private set { this.harvesters = value; }
    }

    public List<Provider> Providers
    {
        get { return this.providers; }
        private set { this.providers = value; }
    }


    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            Harvester newHarv = HarvesterFactory.GetHarvester(arguments);
            this.harvesters.Add(newHarv);

            return $"Successfully registered {arguments[0]} Harvester - {newHarv.Id}";
        }
        catch (System.Exception e)
        {
            return $"{e.Message}";
        }
    }

    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            Provider newProv = ProviderFactory.GetProvider(arguments);
            this.providers.Add(newProv);
            return $"Successfully registered {arguments[0]} Provider - {newProv.Id}";
        }
        catch (System.Exception e)
        {
            return $"{e.Message}";
        }
    }

    public string Day()
    {
        //TODO: Add some logic here …
        return this.DayFactory(this.mode);
    }


    public string Mode(List<string> arguments)
    {
        string modeArg = arguments.FirstOrDefault();
        this.mode = modeArg;
        return $"Successfully changed working mode to {modeArg} Mode";
    }


    public string Check(List<string> arguments)
    {
        return this.GetCheckInfo(arguments.FirstOrDefault());
    }


    public string ShutDown()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.savedEnergy}");
        sb.AppendLine($"Total Mined Plumbus Ore: {this.totalOre}");
        return sb.ToString().Trim();
    }


    // *************************************


    private string GetCheckInfo(string id)
    {
        if (providers.Any(x => x.Id == id))
        {
            return providers.FirstOrDefault(x => x.Id == id).ToString();
        }
        else if (harvesters.Any(x => x.Id == id))
        {
            return harvesters.FirstOrDefault(x => x.Id == id).ToString();
        }
        else
        {
            return $"No element found with id - {id}";
        }
    }


    // Day Manufacturing
    private string DayFactory(string mode)
    {
        double allNeededEnergy = harvesters.Sum(x => x.EnergyRequirement);
        double allOred = harvesters.Sum(x => x.OreOutput);
        double allEnergyProvided = providers.Sum(x => x.EnergyOutput);

        this.savedEnergy += allEnergyProvided;

        double ore = 0;

        switch (mode)
        {
            case "Full":
                if (savedEnergy >= allNeededEnergy)
                {
                    this.savedEnergy -= allNeededEnergy;
                    ore = allOred;
                }
                break;

            case "Half":
                if (savedEnergy >= (allNeededEnergy * 0.6))
                {
                    this.savedEnergy -= allNeededEnergy * 0.6;
                    ore = allOred * 0.5;
                }
                break;
        }

        this.totalOre += ore;
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"A day has passed.");
        sb.AppendLine($"Energy Provided: {allEnergyProvided}");
        sb.AppendLine($"Plumbus Ore Mined: {ore}");
        return sb.ToString().Trim();
    }

}


