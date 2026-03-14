using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Goal> goals = new List<Goal>();
        int score = 0;

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nScore: " + score);
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Show Goals");
            Console.WriteLine("3. Record Goal");
            Console.WriteLine("4. Quit");

            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("1 Simple Goal");
                Console.WriteLine("2 Eternal Goal");
                Console.WriteLine("3 Checklist Goal");

                string type = Console.ReadLine();

                Console.Write("Goal name: ");
                string name = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                {
                    goals.Add(new Simplegoal(name, points));
                }
                else if (type == "2")
                {
                    goals.Add(new Eternalgoal(name, points));
                }
                else if (type == "3")
                {
                    Console.Write("Target count: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());

                    goals.Add(new Checklistgoal(name, points, target, bonus));
                }
            }

            else if (choice == "2")
            {
                Console.WriteLine("\nGoals:");
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].Getstatus()}");
                }
            }

            else if (choice == "3")
            {
                Console.WriteLine("\nSelect goal to record:");

                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].Getstatus()}");
                }

                int number = int.Parse(Console.ReadLine()) - 1;

                int earned = goals[number].Recordevent();
                score += earned;

                Console.WriteLine($"You earned {earned} points!");
            }

            else if (choice == "4")
            {
                running = false;
            }
        }
    }
}