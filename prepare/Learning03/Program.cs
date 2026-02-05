using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);

        Console.WriteLine(f1.Getfractionstring());
        Console.WriteLine(f1.Getdecimalvalue());

        Console.WriteLine(f2.Getfractionstring());
        Console.WriteLine(f2.Getdecimalvalue());

        Console.WriteLine(f3.Getfractionstring());
        Console.WriteLine(f3.Getdecimalvalue());

        Console.WriteLine(f4.Getfractionstring());
        Console.WriteLine(f4.Getdecimalvalue());

        Fraction randomFraction = new Fraction();
        Random rand = new Random();

        for (int i = 1; i <= 20; i++)
        {
            int top = rand.Next(1, 10);
            int bottom = rand.Next(1, 10);

            randomFraction.Settop(top);
            randomFraction.Setbottom(bottom);

            Console.WriteLine($"Fraction {i}: string: {randomFraction.Getfractionstring()} Number: {randomFraction.Getdecimalvalue()}");
        }
    }
}
