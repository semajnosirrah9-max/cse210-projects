using System;

public class Activity
{
    protected string Date;
    protected int Minutes;

    public Activity(string date, int minutes)
    {
        Date = date;
        Minutes = minutes;
    }

    public virtual double Getdistance()
    {
        return 0;
    }

    public virtual double Getspeed()
    {
        return (Getdistance() / Minutes) * 60;
    }

    public virtual double Getpace()
    {
        return Minutes / Getdistance();
    }

    public virtual string Getsummary()
    {
        return $"{Date} ({Minutes} min) - Distance {Getdistance():0.0} km, Speed {Getspeed():0.0} kph, Pace {Getpace():0.0} min per km";
    }
}