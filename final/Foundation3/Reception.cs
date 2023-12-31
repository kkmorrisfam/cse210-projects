

public class Reception : Event
{
    private string _email;

    public Reception(string eventTitle, string description, string date, string time, string email) 
                    : base(eventTitle, description, date, time)
    {
        _email = email;
    }

    public string GetEmail()
    {
        return _email;
    }
    public void SetEmail(string email)
    {
        _email = email;
    }

    public string DisplayFullDetails()
    {
        return base.DisplayDetails() + $"\nRSVP: {GetEmail()}";
    }
 
}