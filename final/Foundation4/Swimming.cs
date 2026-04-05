public class Swimming : Activity
{
    private int Laps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        Laps = laps;
    }

    public override double Getdistance()
    {
        return (Laps * 50) / 1000.0;
    }
}