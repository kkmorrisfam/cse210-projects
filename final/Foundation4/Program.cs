using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Hello from your local Fabulous Fitness Center!");
        Console.WriteLine();
        List<Activity> activities = new List<Activity>();
        //Set numbers for activities
        Running r1 = new Running("20 Oct 2023", 45, 4.5);        
        activities.Add(r1);

        Cycling c1 = new Cycling("21 Oct 2023", 55, 7);        
        activities.Add(c1);

        Swimming s1 = new Swimming("22 Oct 2023", 45, 100);
        activities.Add(s1);

        //Print summaries for each activity
        foreach( Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}