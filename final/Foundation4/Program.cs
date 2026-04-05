using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("Nov 3", 30, 3.0));
        activities.Add(new Cycling("Nov 4", 20, 15.0));
        activities.Add(new Swimming("Nov 5", 40, 20));

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.Getsummary());
        }
    }
}