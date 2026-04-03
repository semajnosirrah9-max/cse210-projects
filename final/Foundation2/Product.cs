public class Product
{
    private string Name, Id;
    private double Price;
    private int Quantity;

    public Product(string name, string id, double price, int quantity)
    {
        Name = name;
        Id = id;
        Price = price;
        Quantity = quantity;
    }

    public double Gettotalcost()
    {
        return Price * Quantity;
    }

    public string Getpackinginfo()
    {
        return $"{Name} ({Id})";
    }
}