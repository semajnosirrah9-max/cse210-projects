public class Goal
{
    protected string _name;
    protected int _points;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
    }

    public virtual int Recordevent()
    {
        return _points;
    }

    public virtual string Getstatus()
    {
        return _name;
    }
}