public class Outdoor : Event
{
    private string Weather;

    public Outdoor(string t, string d, string date, string time, string addr, string weather)
        : base(t, d, date, time, addr)
    {
        Weather = weather;
    }

    public override string Getfull()
    {
        return $"{Getstandard()} Weather: {Weather}";
    }
}