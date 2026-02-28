using System;
using System.Collections.Generic;

public class Reflection : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone.",
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection()
    {
        _name = "Reflection";
        _discription = "This activity helps you reflect on times when you showed strength.";
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
            Console.WriteLine(_questions[rand.Next(_questions.Count)]);
            Showspinner(4);
            time += 4;
        }

        End();
    }
}