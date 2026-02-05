using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();

        List<string> prompts = new List<string>
        {
            "What was the best part of my day?",
            "What challenged me today?",
            "What am I grateful for today?",
            "What did I learn today?",
            "Who made a positive impact on me today?",
            "What moment do I want to remember from today?",
            "What could I improve tomorrow?",
            "Did you watch anything intresting or good today?"
        };

        Random rand = new Random();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    string prompt = prompts[rand.Next(prompts.Count)];
                    Console.WriteLine(prompt);
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    string date = DateTime.Now.ToShortDateString();
                    journal.AddEntry(new Entry(date, prompt, response));

                    Console.WriteLine("Entry added.\n");
                    break;

                case "2":
                    journal.Displayall();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    journal.Savetofile(Console.ReadLine());
                    Console.WriteLine("Journal saved.\n");
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    journal.Loadfromfile(Console.ReadLine());
                    Console.WriteLine("Journal loaded.\n");
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.\n");
                    break;
            }
        }
    }
}