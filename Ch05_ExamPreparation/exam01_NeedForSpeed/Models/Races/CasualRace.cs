using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CasualRace : Race
{

    public CasualRace(int length, string route, int prizePool)
        : base(length, route, prizePool)
    {
    }



    //protected override List<Car> PerfPoints()
    //{
    //    this.CalculatePoints();
    //    return this.Participants.OrderByDescending(x => x.CarPPoints).Take(3).ToList();
    //}


    protected override void CalculatePoints()
    {
        foreach (Car c in this.Participants)
        {
            c.CarPPoints = (c.Horsepower / c.Acceleration) + (c.Suspension + c.Durability);
        }
    }


    //public override string ToString()
    //{
    //    List<Car> winners = this.PerfPoints();
    //    StringBuilder sb = new StringBuilder();

    //    sb.AppendLine($"{this.Route} - {this.Length}");

    //    int part = winners.Count;
    //    int num = Math.Min(part, 3);

    //    for (int i = 1; i <= num; i++)
    //    {
    //        Car car = winners.Skip(i - 1).FirstOrDefault();
    //        int winPrize=0;
    //        switch (i)
    //        {
    //            case 1: winPrize = (int)(this.PrizePool*0.5);
    //                break;
    //            case 2: winPrize = (int)(this.PrizePool*0.3);
    //                break;
    //            case 3: winPrize = (int)(this.PrizePool*0.2);
    //                break;
    //        }

    //        sb.AppendLine($"{i}. {car.Brand} {car.Model} {car.CarPPoints}PP - ${winPrize}");
    //    }

    //    return sb.ToString();
    //}

}
