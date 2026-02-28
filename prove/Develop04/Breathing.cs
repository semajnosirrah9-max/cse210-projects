using System;

public class Breathing : Activity
{
    public Breathing()
    {
        _name = "Breathing";
        _discription = "This activity will help you relax by walking you through breathing in and out slowly. \nClear your mind and focus on your breathing.";
    }

    public void Run()
    {
        Start();

        int time = 0;
        while (time < _duration)
        {
            Console.Write("Breathe in... ");
            Showcountdown(4);
            Console.WriteLine();

            Console.Write("Breathe out... ");
            Showcountdown(4);
            Console.WriteLine();

            time += 8;
        }

        End();
    }
}