using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;
    protected List<Car> participants;

    protected Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.participants = new List<Car>();
    }


    public int Length
    {
        get { return this.length; }
        protected set { this.length = value; }
    }

    public string Route
    {
        get { return this.route; }
        set { this.route = value; }
    }

    public int PrizePool
    {
        get { return this.prizePool; }
        set { this.prizePool = value; }
    }

    public List<Car> Participants
    {
        get { return this.participants; }
        set { this.participants = value; }
    }


    protected virtual List<Car> PerfPoints()
    {
        this.CalculatePoints();
        return this.Participants.OrderByDescending(x => x.CarPPoints).Take(3).ToList();

    }

    protected abstract void CalculatePoints();


    public override string ToString()
    {
        List<Car> winners = this.PerfPoints();
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"{this.Route} - {this.Length}");

        int num = winners.Count < 3 ? winners.Count : 3;

        for (int i = 1; i <= num; i++)
        {
            Car car = winners.Skip(i - 1).FirstOrDefault();
            int winPrize = 0;
            switch (i)
            {
                case 1:
                    winPrize = (this.PrizePool * 50)/100;
                    break;
                case 2:
                    winPrize = (this.PrizePool * 30) / 100;
                    break;
                case 3:
                    winPrize = (this.PrizePool * 20) / 100;
                    break;
            }

            sb.AppendLine($"{i}. {car.Brand} {car.Model} {car.CarPPoints}PP - ${winPrize}");
        }

        return sb.ToString();
    }

}
