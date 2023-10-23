
public class Event
{
    private string _eventTitle;
    private string _desciption;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string eventTitle, string description, string date, string time)
    {
        _eventTitle = eventTitle;
        _desciption = description;
        _date = date;
        _time = time;        
    }

    public void SetAddress(string street, string city, string state, string country)
    {
        _address = new Address(street, city, state, country);
    }
    public string GetAddress()
    {
        return _address.GetAddress();
    }
    public string GetEventTitle()
    {
        return _eventTitle;
    }
    public string GetDescription()
    {
        return _desciption;
    }
    public string GetDate()
    {
        return _date;        
    }
    public string GetTime()
    {
        return _time;
    }
    public string DisplayDetails()
    {
        return $"{GetEventTitle()}\n{GetDescription()}\n{GetDate()} {GetTime()}\n{GetAddress()}";
    }
    // public void DisplayFullDetails()
    // {

    // }
    public string DisplayShortDescription()
    {
        return $"{GetEventTitle()}: {GetDescription()}  --  {GetDate()}";
    }

}