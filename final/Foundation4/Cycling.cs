public class Cycling : Activity
{
    private double Speed;

    public Cycling(string date, int minutes, double speed)
        : base(date, minutes)
    {
        Speed = speed;
    }

    public override double Getspeed()
    {
        return Speed;
    }

    public override double Getdistance()
    {
        return (Speed * Minutes) / 60;
    }
}