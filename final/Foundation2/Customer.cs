public class Customer
{
    private string Name;
    private Address Adress;

    public Customer(string name, Address adress)
    {
        Name = name;
        Adress = adress;
    }

    public bool LivesinUSA()
    {
        return Adress.IsUSA();
    }

    public string GetName() => Name;
    public string Getadress() => Adress.Getfulladress();
}