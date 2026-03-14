public class Checklistgoal : Goal
{
    private int _target;
    private int _count = 0;
    private int _bonus;

    public Checklistgoal(string name, int points, int target, int bonus) : base(name, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override int Recordevent()
    {
        _count++;

        if (_count == _target)
        {
            return _points + _bonus;
        }

        return _points;
    }

    public override string Getstatus()
    {
        return "[ ] " + _name + $" {_count}/{_target}";
    }
}