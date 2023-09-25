using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction myFraction1 = new Fraction();
        Fraction myFraction2 = new Fraction(5);
        Fraction myFraction3 = new Fraction(2, 3);
        
        //test getters and setters
        myFraction1.SetTop(4);
        myFraction2.Setbottom(5);
        Console.WriteLine($"Fraction 1: {myFraction1.GetTop()}/{myFraction1.GetBottom()}");
        Console.WriteLine($"Fraction 2: {myFraction2.GetTop()}/{myFraction2.GetBottom()}");
        Console.WriteLine($"Fraction 3: {myFraction3.GetTop()}/{myFraction3.GetBottom()}");

        //test GetFractionString()
        Console.WriteLine(myFraction1.GetFractionString());
        Console.WriteLine(myFraction2.GetFractionString());
        Console.WriteLine(myFraction3.GetFractionString());

        //test GetDecimalValue()
        Console.WriteLine(myFraction1.GetDecimalValue());
        Console.WriteLine(myFraction2.GetDecimalValue());
        Console.WriteLine(myFraction3.GetDecimalValue());

    }
}