using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicnumber)
        {
            Console.Write("Guess a number between 1-100.\nWhat is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicnumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicnumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}