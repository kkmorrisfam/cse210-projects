using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");

        //Set numbers for activities
        Running r1 = new Running("20 Oct 2023", 45, 4.5);
        Console.WriteLine(r1.GetSummary());

        //Print summaries for each activity
    }
}