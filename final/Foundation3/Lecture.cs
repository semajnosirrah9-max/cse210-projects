public class Lecture : Event
{
    private string Speaker;
    private int Capacity;

    public Lecture(string t, string d, string date, string time, string addr, string speaker, int cap)
        : base(t, d, date, time, addr)
    {
        Speaker = speaker;
        Capacity = cap;
    }

    public override string Getfull()
    {
        return $"{Getstandard()} Speaker: {Speaker}, Capacity: {Capacity}";
    }
}