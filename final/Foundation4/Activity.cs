using System.Runtime;
using System.Runtime.CompilerServices;

public abstract class Activity
{
    private string _date;
    private double _minutes;

    //Constructor
    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date;
    }
    public double GetMinutes()
    {
        return _minutes;
    }
    //abstract methods must be defined in derived classes
    //need to be virtual instead?  
    public abstract double GetDistance();
    public virtual double GetSpeed()
    {
        return 60/ GetPace();
    }
    public virtual double GetPace()
    {
        return 60 / GetSpeed();
    }
    
    //can I use the abstract methods in the GetSummary? Or maybe that's why they need to be virtual instead of abstract? Yes I can
    public virtual string GetSummary()
    {
        //can I do this? Yes I can
        string summary = $"{_date} {GetType()} ({GetMinutes()} min) - Distance {GetDistance()} miles, Speed: {GetSpeed()}mph, Pace {GetPace()} min per mile.";
        return summary;
    }


} //end class