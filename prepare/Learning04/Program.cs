using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.Getsummary());
        Console.WriteLine();

        Mathassignment math = new Mathassignment(
            "Roberto Rodriguez",
            "Fractions",
            "7.3",
            "8-19"
        );

        Console.WriteLine(math.Getsummary());
        Console.WriteLine(math.Gethomeworklist());
        Console.WriteLine();

        Writingassignment writing = new Writingassignment(
            "Mary Waters",
            "European History",
            "The Causes of World War II"
        );

        Console.WriteLine(writing.Getsummary());
        Console.WriteLine(writing.Getwritinginformation());
    }
}
