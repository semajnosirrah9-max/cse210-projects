using System;

class Program
{
    static void Main()
    {
        Event e1 = new Lecture("Lecture", "Science Talk", "Jan 1", "5pm", "Hall", "Dr. Smith", 100);
        Event e2 = new Reception("Reception", "Meet & Greet", "Feb 1", "6pm", "Center", "rsvp@email.com");
        Event e3 = new Outdoor("Outdoor", "Picnic", "Mar 1", "12pm", "Park", "Sunny");

        Event[] events = { e1, e2, e3 };

        foreach (Event e in events)
        {
            Console.WriteLine(e.Getstandard());
            Console.WriteLine(e.Getfull());
            Console.WriteLine(e.Getshort());
            Console.WriteLine();
        }
    }
}