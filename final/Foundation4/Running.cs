public class Running : Activity
{
    private double Distance;

    public Running(string date, int minutes, double distance)
        : base(date, minutes)
    {
        Distance = distance;
    }

    public override double Getdistance()
    {
        return Distance;
    }
}