
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

    public void GetAddress(string street, string city, string state, string country)
    {
        _address = new Address(street, city, state, country);
    }
    public void DisplayDetails()
    {

    }
    // public void DisplayFullDetails()
    // {

    // }
    public void DisplayShortDescription()
    {

    }

}