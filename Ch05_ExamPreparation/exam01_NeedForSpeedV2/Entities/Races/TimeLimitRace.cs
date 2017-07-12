using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TimeLimitRace : Race
{
    private int goldTime;
    public TimeLimitRace(int length, string route, int prizePool, int goldTime) : base(length, route, prizePool)
    {
        this.GoldTime = goldTime;
    }

    public int GoldTime
    {
        get { return this.goldTime; }
        set { this.goldTime = value; }
    }

    public override List<Car> Participants
    {
        get { return base.Participants; }
        set
        {
            if (!base.Participants.Any())
            {
                base.Participants = value;
            }
        }
    }

    protected override List<Car> PerfPoints()
    {
        this.CalculatePoints();
        return this.Participants;
    }


    protected override void CalculatePoints()
    {
        Car car = this.Participants.FirstOrDefault();
        car.CarPPoints = this.Length * (car.Horsepower / 100) * car.Acceleration;
    }

    private string GetPrize(Car car)
    {
        int points = car.CarPPoints;
        if (points <= this.GoldTime)
        {
            return $"Gold Time, ${this.PrizePool}.";
        }
        else if (points <= (this.GoldTime + 15))
        {
            return $"Silver Time, ${((this.PrizePool * 50) / 100)}.";
        }
        else
        {
            return $"Bronze Time, ${((this.PrizePool * 30) / 100)}.";
        }
    }


    public override string ToString()
    {
        Car car = this.PerfPoints().FirstOrDefault();
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"{this.Route} - {this.Length}");
        sb.AppendLine($"{car.Brand} {car.Model} - {car.CarPPoints} s.");
        sb.AppendLine(GetPrize((car)));

        return sb.ToString();
    }

}
