public class RaceFactory
{
    public static Race GetRace(string type, int length, string route, int prizePool)
    {
        switch (type)
        {
            case "Casual":
                return new CasualRace(length, route, prizePool);
            case "Drag":
                return new DragRace(length, route, prizePool);
            case "Drift":
                return new DriftRace(length, route, prizePool);

            default:
                return null;
        }
    }

    public static Race GetRace(string type, int length, string route, int prizePool, int someParam)
    {
        switch (type)
        {
            case "TimeLimit":
                return new TimeLimitRace(length, route, prizePool, someParam);
            case "Circuit":
                return new CircuitRace(length, route, prizePool, someParam);

            default:
                return null;
        }
    }

}

