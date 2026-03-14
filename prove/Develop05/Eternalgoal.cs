public class Eternalgoal : Goal
{
    public Eternalgoal(string name, int points) : base(name, points)
    {
    }

    public override int Recordevent()
    {
        return _points;
    }

    public override string Getstatus()
    {
        return "[∞] " + _name;
    }
}