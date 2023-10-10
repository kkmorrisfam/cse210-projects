using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square("Blue", 4);
        // double area = mySquare.GetArea();            
        // Console.WriteLine($"Square Area: {area}");
        // Console.WriteLine($"The color is: {mySquare.GetColor()}");

        Rectangle myRectangle = new Rectangle("Green", 6, 8.5);
        // Console.WriteLine($"Rectangle area: {myRectangle.GetArea()}");
        // Console.WriteLine($"Rectangle color: {myRectangle.GetColor()}");

        Circle myCircle = new Circle("Yellow", 3.5);
        // Console.WriteLine($"Circle area: {myCircle.GetArea()}");
        // Console.WriteLine($"Circle color: {myCircle.GetColor()}");

        List<Shape> shapesList = new List<Shape>();
        shapesList.Add(mySquare);
        shapesList.Add(myRectangle);
        shapesList.Add(myCircle);

        foreach(Shape shape in shapesList)
        {
            Console.WriteLine($"Shape Area: {shape.GetArea()}");
            Console.WriteLine($"The color is: {shape.GetColor()}");            
        }

    }
}