public class Event
{
    protected string Title, Description, Date, Time, Adress;

    public Event(string title, string desc, string date, string time, string address)
    {
        Title = title;
        Description = desc;
        Date = date;
        Time = time;
        Adress = address;
    }

    public virtual string Getstandard()
    {
        return $"{Title} - {Description} on {Date} at {Time}, {Adress}";
    }

    public virtual string Getfull()
    {
        return Getstandard();
    }

    public string Getshort()
    {
        return $"{Title} on {Date}";
    }
}