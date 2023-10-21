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
        return GetMinutes() / _distance; //Get a stackoverflow if I use the base method
    }

}//end Running class