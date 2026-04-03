using System.Collections.Generic;

public class Order
{
    private List<Product> Products = new List<Product>();
    private Customer Customer;

    public Order(Customer customer)
    {
        Customer = customer;
    }

    public void Addproduct(Product p)
    {
        Products.Add(p);
    }

    public double Gettotalcost()
    {
        double total = 0;

        foreach (Product p in Products)
        {
            total += p.Gettotalcost();
        }

        total += Customer.LivesinUSA() ? 5 : 35;

        return total;
    }

    public string Getpackinglabel()
    {
        string result = "";
        foreach (Product p in Products)
        {
            result += p.Getpackinginfo() + "\n";
        }
        return result;
    }

    public string Getshippinglabel()
    {
        return $"{Customer.GetName()}\n{Customer.Getadress()}";
    }
}