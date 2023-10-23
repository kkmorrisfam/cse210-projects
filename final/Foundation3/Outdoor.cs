public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string eventTitle, string description, string date, string time, string weather) 
                : base(eventTitle, description, date, time)
    {
        _weather = weather;
    }
    public string GetWeather()
    {
        return _weather;
    }
    public void SetWeather(string weather)
    {
        _weather = weather;
    }
    public string DisplayAdditionalDetails()
    {
        return $"Weather Outlook: {GetWeather()}";
    }
}