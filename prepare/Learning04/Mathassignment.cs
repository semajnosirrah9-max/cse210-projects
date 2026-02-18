public class Mathassignment : Assignment
{
    private string _section;
    private string _problems;

    public Mathassignment(string studentname, string topic, string section, string problems)
        : base(studentname, topic)
    {
        _section = section;
        _problems = problems;
    }

    public string Gethomeworklist()
    {
        return $"Section {_section} Problems {_problems}";
    }
}
