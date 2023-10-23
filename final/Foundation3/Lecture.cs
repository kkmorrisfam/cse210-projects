public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    
    //do I add variables from Event? or use setters?
    public Lecture(string eventTitle, string description, string date, string time, string speaker, int capacity) 
                    : base(eventTitle, description, date, time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }

    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }

    public string DisplayAdditionalDetails()
    {
        return $"Speaker: {GetSpeaker()} --  Capacity: {GetCapacity()}";
    }
}