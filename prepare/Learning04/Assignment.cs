public class Assignment
{
    private string _studentname;
    private string _topic;

    public Assignment(string studentname, string topic)
    {
        _studentname = studentname;
        _topic = topic;
    }

    public string Getsummary()
    {
        return $"{_studentname} - {_topic}";
    }

    public string Getstudentname()
    {
        return _studentname;
    }
}
