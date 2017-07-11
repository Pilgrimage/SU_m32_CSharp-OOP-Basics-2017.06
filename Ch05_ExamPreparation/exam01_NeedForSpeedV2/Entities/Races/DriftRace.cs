public class DriftRace : Race
{
    public DriftRace(int length, string route, int prizePool)
        : base(length, route, prizePool)
    {
    }

    protected override void CalculatePoints()
    {
        foreach (Car c in this.Participants)
        {
            c.CarPPoints = (c.Suspension + c.Durability);
        }
    }

}

