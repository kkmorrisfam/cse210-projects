using System.IO.Compression;

public class BreathingActivity : Activity
{
    //constructor
    public BreathingActivity() : base()  //use default base constructor.  Is this what this does?
    {
        //set default values
        _name = "Breathing";
        _description = @"This activity will help you relax by walking you through breathing in and out slowly.  
Clear your mind and focus on your breathing.";
        SetDuration(60);

    }

    public BreathingActivity(string name, string description) : base(name, description)
    {
        // _name = name;
        // _description = description;
    }

    public void Run()
    {
        //run the program for the breathing activity
        DisplayStartingMessage();
        
        //needs a loop for the duration
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());  //accepts a double, GetDuration returns an int

        while (DateTime.Now < endTime)
        {
            Console.Write("Breath in...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Now breath out...");
            ShowCountDown(7);
            Console.WriteLine();
            Console.WriteLine();
        }
        
        DisplayEndingMessage();
 
    }
 
} //end BreathingActivity class