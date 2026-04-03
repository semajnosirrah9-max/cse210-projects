public class Reception : Event
{
    private string Email;

    public Reception(string t, string d, string date, string time, string addr, string email)
        : base(t, d, date, time, addr)
    {
        Email = email;
    }

    public override string Getfull()
    {
        return $"{Getstandard()} RSVP: {Email}";
    }
}