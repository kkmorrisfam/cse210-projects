using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");

        //Set numbers for activities
        Running r1 = new Running("20 Oct 2023", 45, 4.5);
        Console.WriteLine(r1.GetSummary());

        Cycling c1 = new Cycling("21 Oct 2023", 55, 6);
        Console.WriteLine(c1.GetSummary());

        Swimming s1 = new Swimming("22 Oct 2023", 40, 50);
        Console.WriteLine(s1.GetSummary());

        //Print summaries for each activity
    }
}