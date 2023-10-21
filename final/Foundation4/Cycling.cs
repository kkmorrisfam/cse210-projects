public class Cycling : Activity
{
    private double _speed;

    //constructor
    public Cycling(string date, double minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetDistance()
    {
        return _speed * (GetMinutes()/60);
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
} //end class