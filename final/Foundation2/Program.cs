using System;

class Program
{
    static void Main()
    {
        Address a1 = new Address("123 St", "Arab", "AL", "USA");
        Customer c1 = new Customer("Jake", a1);

        Order o1 = new Order(c1);
        o1.Addproduct(new Product("Book", "B1", 10, 2));
        o1.Addproduct(new Product("Pen", "P1", 2, 5));

        Address a2 = new Address("456 Rd", "Toronto", "ON", "Canada");
        Customer c2 = new Customer("Alex", a2);

        Order o2 = new Order(c2);
        o2.Addproduct(new Product("Laptop", "L1", 500, 1));
        o2.Addproduct(new Product("Mouse", "M1", 20, 2));

        Console.WriteLine("Order 1:");
        Console.WriteLine(o1.Getpackinglabel());
        Console.WriteLine($"Name: {o1.Getshippinglabel()}");
        Console.WriteLine($"Total Cost: ${o1.Gettotalcost():F2}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(o2.Getpackinglabel());
        Console.WriteLine($"Name: {o2.Getshippinglabel()}");
        Console.WriteLine($"Total Cost: ${o2.Gettotalcost():F2}");
    }
}