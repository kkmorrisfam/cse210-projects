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
        // return ((_laps * 50) / 1000) * 0.62; //with or without parenthesis - does same thing
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetPace()
    {
        //I get a stackoverflow if I don't override this method here with same formula.
        return GetMinutes() / GetDistance();
        // return 60 / GetSpeed();  // I get a stackoverflow if I use this formula.
    }
   

}//end class