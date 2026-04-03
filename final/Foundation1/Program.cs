using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Cooking Pasta", "Chef Mike", 300);
        v1.Addcomment(new Comment("Anna", "Looks tasty!"));
        v1.Addcomment(new Comment("Bob", "Thanks for the tips"));
        v1.Addcomment(new Comment("Chris", "Dang, you making me hungry"));

        Video v2 = new Video("Gaming Highlights", "ProGamer", 600);
        v2.Addcomment(new Comment("Alex", "So cool!"));
        v2.Addcomment(new Comment("Sam", "sick!"));
        v2.Addcomment(new Comment("Jordan", "LOL"));

        Video v3 = new Video("Workout Routine", "FitLife", 900);
        v3.Addcomment(new Comment("Taylor", "Very helpful"));
        v3.Addcomment(new Comment("Morgan", "I’m tired already"));
        v3.Addcomment(new Comment("Casey", "Good tips"));

        Video v4 = new Video("Travel Vlog", "Explorer", 450);
        v4.Addcomment(new Comment("Jamie", "Beautiful place"));
        v4.Addcomment(new Comment("Riley", "I want to go there"));
        v4.Addcomment(new Comment("Drew", "I would get lost"));

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);
        videos.Add(v4);

        foreach (Video v in videos)
        {
            v.Display();
        }
    }
}