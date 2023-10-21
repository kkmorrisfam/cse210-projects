public class Swimming : Activity
{
    private double _laps;

    //constructor
    public Swimming(string date, double minutes, double laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public double GetLaps()
    {
        return _laps;
    }
    public override double GetDistance()
    {
        return ((_laps * 50) / 1000) * 0.62;
        // return _laps * 50 / 1000 * 0.62;
    }
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

    // public override double GetSpeed()
    // {
    //     // throw new NotImplementedException();
    //     return 60 / GetPace();
    // }

}//end class