public class Writingassignment : Assignment
{
    private string _title;

    public Writingassignment(string studentname, string topic, string title)
        : base(studentname, topic)
    {
        _title = title;
    }

    public string Getwritinginformation()
    {
        return $"{_title} by {Getstudentname()}";
    }
}
