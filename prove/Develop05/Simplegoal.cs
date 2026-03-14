public class Simplegoal : Goal
{
    private bool _complete = false;

    public Simplegoal(string name, int points) : base(name, points)
    {
    }

    public override int Recordevent()
    {
        if (!_complete)
        {
            _complete = true;
            return _points;
        }
        return 0;
    }

    public override string Getstatus()
    {
        return (_complete ? "[X] " : "[ ] ") + _name;
    }
}