using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private string mode;
    private double savedEnergy;
    private List<Harvester> harvesters;
    private List<Provider> providers;
    private List<Day> days;

    public DraftManager()
    {
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
        this.days = new List<Day>();

        this.mode = "Full";
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

    public List<Day> Days
    {
        get { return this.days; }
        private set { this.days = value; }
    }


    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            Harvester newHarv = this.GetHarvester(arguments);
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
            Provider newProv = this.GetProvider(arguments);
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
        //this.mode = arguments.FirstOrDefault();
        return this.GetCheckInfo(arguments.FirstOrDefault());
    }


    public string ShutDown()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.savedEnergy}");
        sb.AppendLine($"Total Mined Plumbus Ore: {this.days.Sum(x => x.OreMined)}");
        return sb.ToString().Trim();
    }




    // Harvester Factory
    private Harvester GetHarvester(List<string> arguments)
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

    // Provider Factory
    private Provider GetProvider(List<string> arguments)
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

    private string GetCheckInfo(string id)
    {
        if (providers.Any(x => x.Id == id))
        {
            Provider prov = providers.FirstOrDefault(x => x.Id == id);
            return prov.ToString();
        }
        else if (harvesters.Any(x => x.Id == id))
        {
            Harvester harv = harvesters.FirstOrDefault(x => x.Id == id);
            return harv.ToString();
        }
        else
        {
            return $"No element found with id - {id}";
        }
    }


    // Day Factory !?!?!?
    private string DayFactory(string mode)
    {
        double energy = 0;
        double ore = 0;

        double allNeededEnergy = harvesters.Sum(x => x.EnergyRequirement);
        double allOred = harvesters.Sum(x => x.OreOutput);

        double allEnergy = providers.Sum(x => x.EnergyOutput);
        double restEnergy;

        energy = allEnergy;

        switch (mode)
        {
            case "Full":
                if (allEnergy >= allNeededEnergy)
                {
                    restEnergy = (allEnergy - allNeededEnergy);
                    this.savedEnergy += restEnergy;
                    energy = restEnergy;
                    ore = allOred;
                }
                else
                {
                    restEnergy = allEnergy;
                    this.savedEnergy += restEnergy;
                    energy = restEnergy;
                    ore = 0;
                }
                break;

            case "Half":

                if (allEnergy >= allNeededEnergy*0.6)
                {
                    restEnergy = (allEnergy - allNeededEnergy * 0.6);
                    this.savedEnergy += restEnergy;
                    energy = restEnergy;
                    ore = allOred*0.5;
                }
                else
                {
                    restEnergy = allEnergy;
                    this.savedEnergy += restEnergy;
                    energy = restEnergy;
                    ore = 0;
                }

                break;

            case "Energy":
                energy = allEnergy;
                this.savedEnergy += allEnergy;
                ore = 0;
                break;


        }


        Day newDay = new Day(energy, ore);
        this.days.Add(newDay);
        return newDay.ToString();
    }



}


