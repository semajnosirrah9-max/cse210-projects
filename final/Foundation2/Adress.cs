public class Address
{
    private string Street, City, State, Country;

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public bool IsUSA()
    {
        return Country == "USA";
    }

    public string Getfulladress()
    {
        return $"{Street}, {City}, {State}, {Country}";
    }
}