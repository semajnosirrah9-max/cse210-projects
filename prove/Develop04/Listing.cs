using System;
using System.Collections.Generic;

public class Listing : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing()
    {
        _name = "Listing";
        _discription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        Start();

        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        Showspinner(3);

        int time = 0;
        while (time < _duration)
        {
            Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
            Showspinner(4);
            time += 4;
        }

        End();
    }
}
