using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void Addcomment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int Getcommentcount()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"{_title} by {_author} ({_length}s)");
        Console.WriteLine($"Comments: {Getcommentcount()}");

        foreach (Comment c in _comments)
        {
            Console.WriteLine($" - {c.Getdisplay()}");
        }

        Console.WriteLine();
    }
}