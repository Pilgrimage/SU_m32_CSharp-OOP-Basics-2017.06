using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CircuitRace : CasualRace
{
    public CircuitRace(int length, string route, int prizePool, int laps) : base(length, route, prizePool)
    {
        this.Laps = laps;
    }

    public int Laps { get; set; }

    protected override List<Car> PerfPoints()
    {
        this.CalculatePoints();
        return this.Participants.OrderByDescending(x => x.CarPPoints).Take(4).ToList();
    }

    protected override void CalculatePoints()
    {
        foreach (Car c in this.Participants)
        {
            c.Durability -= this.Laps * this.Length * this.Length;
            c.CarPPoints = (c.Horsepower / c.Acceleration) + (c.Suspension + c.Durability);
        }
    }


    private int GetPrize(int number)
    {
        switch (number)
        {
            case 1: return (this.PrizePool * 40) / 100;
            case 2: return (this.PrizePool * 30) / 100;
            case 3: return (this.PrizePool * 20) / 100;
            case 4: return (this.PrizePool * 10) / 100;
            default: return 0;
        }
    }
    

    public override string ToString()
    {
        List<Car> winners = this.PerfPoints();
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"{this.Route} - {this.Length*this.Laps}");

        int num = winners.Count < 4 ? winners.Count : 4;

        for (int i = 1; i <= num; i++)
        {
            Car car = winners.Skip(i - 1).FirstOrDefault();
            sb.AppendLine($"{i}. {car.Brand} {car.Model} {car.CarPPoints}PP - ${this.GetPrize(i)}");
        }

        return sb.ToString().Trim();
    }
}
