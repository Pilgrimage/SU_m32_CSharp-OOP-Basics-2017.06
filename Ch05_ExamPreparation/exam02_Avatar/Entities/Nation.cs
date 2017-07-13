using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Nation
{
    private List<Bender> benders;
    private List<Monument> monuments;

    public Nation()
    {
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
    }

    public List<Bender> Benders
    {
        get { return this.benders; }
        set { this.benders = value; }
    }

    public List<Monument> Monuments
    {
        get { return this.monuments; }
        set { this.monuments = value; }
    }


    public double GetTotalPower()
    {
        int totalMonumentAffinity = this.monuments.Sum(x => x.GetAffinity());
        double totalBendersPower = this.benders.Sum(x => x.GetPower());
        double totalPowerIncrease = (totalBendersPower / 100) * totalMonumentAffinity;

        return (totalBendersPower + totalPowerIncrease);
    }

    public void AddBender(Bender bender)
    {
        this.Benders.Add(bender);
    }

    public void AddMonument(Monument monument)
    {
        this.monuments.Add(monument);
    }

    public void ClearAll()
    {
        this.Benders.Clear();
        this.Monuments.Clear();
    }


    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        if (this.Benders.Count==0)
        {
            sb.AppendLine($"Benders: None");
        }
        else
        {
            sb.AppendLine($"Benders:");
            foreach (Bender bender in this.Benders)
            {
                sb.AppendLine(bender.ToString());
            }
        }

        if (this.Monuments.Count == 0)
        {
            sb.AppendLine($"Monuments: None");
        }
        else
        {
            sb.AppendLine($"Monuments:");
            foreach (Monument monument in this.Monuments)
            {
                sb.AppendLine(monument.ToString());
            }
        }

        return sb.ToString().Trim();

    }
}

