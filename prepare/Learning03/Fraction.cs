using System;
using System.Security.Cryptography;

class Fraction
{
    //Variables
    private int _top;
    private int _bottom;

//constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;

    }
    
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //methods
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void Setbottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string myString = $"{_top}/{_bottom}";
        return myString;
    }

    public double GetDecimalValue()
    {
        double myNumber = (double)_top/(double)_bottom;
        return myNumber;
    }
    
}