using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Cool Video", "James", 120);
        v1.Addcomment(new Comment("Bob", "Nice!"));
        v1.Addcomment(new Comment("Anna", "Loved it!"));

        Video v2 = new Video("Gaming Clip", "Alex", 300);
        v2.Addcomment(new Comment("Chris", "Epic"));

        videos.Add(v1);
        videos.Add(v2);

        foreach (Video v in videos)
        {
            v.Display();
        }
    }
}