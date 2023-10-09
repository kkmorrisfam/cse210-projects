using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square("Blue", 4);
        double area = mySquare.GetArea();            
        Console.WriteLine($"Square Area: {area}");
        Console.WriteLine($"The color is: {mySquare.GetColor()}");

        Rectangle myRectangle = new Rectangle("Red", 6, 8.5);
        Console.WriteLine($"Rectangle area: {myRectangle.GetArea()}");
        Console.WriteLine($"Rectangle color: {myRectangle.GetColor()}");
    }
}