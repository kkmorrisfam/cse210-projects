public class Running : Activity
{
    private double _distance;

    public Running(string date, double minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public void SetDistance(double distance)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetPace()
    {
        //pace = time / distance
        return GetMinutes() / _distance;
    }
    public override double GetSpeed()
    {
        // speed = (distance / time) * 60 for MPH
        return (_distance / GetMinutes()) * 60;
    }
    // public override string GetSummary()
    // {
    //     //can I do this?
    //     string summary = $"{_date} Running  ({GetMinutes()} min) - Distance {GetDistance()} miles, Speed: {GetSpeed()}mph, Pace {GetPace()} min per mile.";
    //     return summary;
    // }

}//end Running class