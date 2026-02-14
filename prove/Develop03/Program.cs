using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture1 = new Scripture(reference1, "Trust in the Lord with all thine heart and lean not unto thine own understanding");

        Reference reference2 = new Reference("John", 3, 16);
        Scripture scripture2 = new Scripture(reference2, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        List<Scripture> scriptures = new List<Scripture>();
        scriptures.Add(scripture1);
        scriptures.Add(scripture2);

        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.Allwordshidden())
            {
                break;
            }

            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.Hiderandomwords(3);
        }

        Console.Clear();
scripture.Display();
Console.WriteLine();
Console.WriteLine("You have now, hopefully, memorized the scripture!");
    }
}