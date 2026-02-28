using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _discription;
    protected int _duration;

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine();
        Console.WriteLine(_discription);
        Console.WriteLine();
        Console.Write("How many seconds would you like to do this activity? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to start: ");
        Showspinner(3);
    }

    public void End()
    {
        Console.WriteLine("\nWell done!");
        Showspinner(3);

        Console.WriteLine($"\nYou have completed the {_name} Activity for {_duration} seconds.");
        Showspinner(3);
    }

    protected void Showspinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void Showcountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void Run()
    {
    }
}