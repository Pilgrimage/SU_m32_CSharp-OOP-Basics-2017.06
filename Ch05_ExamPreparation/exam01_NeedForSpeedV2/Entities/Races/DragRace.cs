public class DragRace : Race
{
    public DragRace(int length, string route, int prizePool)
        : base(length, route, prizePool)
    {
    }


    protected override void CalculatePoints()
    {
        foreach (Car c in this.Participants)
        {
            c.CarPPoints = (c.Horsepower / c.Acceleration);
        }
    }

}

