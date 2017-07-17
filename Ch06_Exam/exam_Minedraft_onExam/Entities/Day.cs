using System.Text;

public class Day
{
    private double energyProvided;
    private double oreMined;

    public Day(double energyProvided, double oreMined)
    {
        this.energyProvided = energyProvided;
        this.oreMined = oreMined;
    }

    public double EnergyProvided { get { return this.energyProvided; } }
    public double OreMined { get { return this.oreMined; } }



    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"A day has passed.");
        sb.AppendLine($"Energy Provided: {this.energyProvided}");
        sb.AppendLine($"Plumbus Ore Mined: {this.oreMined}");

        return sb.ToString().Trim();
    }
}

