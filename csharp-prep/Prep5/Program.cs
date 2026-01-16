using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string username = Promptusername();
        int favoritenumber = Promptusernumber();

        int squarednumber = Squarenumber(favoritenumber);

        int birthyear;
        Promptuserbirthyear(out birthyear);

        DisplayResult(username, squarednumber, birthyear);
    }

    static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

    static string Promptusername()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int Promptusernumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static void Promptuserbirthyear(out int birthyear)
    {
        Console.Write("Please enter the year you were born: ");
        birthyear = int.Parse(Console.ReadLine());
    }

    static int Squarenumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square, int birthyear)
    {
        int Currentyear = DateTime.Now.Year;
        int age = Currentyear - birthyear;

        Console.WriteLine($"{name}, the square of your number is {square}");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
}