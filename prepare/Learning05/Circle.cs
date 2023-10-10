public class Circle : Shape
{
    private double _radius;
    private double _pi = 3.14159;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return (_radius * _radius) * _pi;
        //return base.GetArea();
    }
}