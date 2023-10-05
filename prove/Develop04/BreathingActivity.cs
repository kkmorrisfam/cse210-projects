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
        _duration = 60;

    }

    public BreathingActivity(string name, string description) : base(name, description)
    {
        // _name = name;
        // _description = description;
    }

    public void Run()
    {
        //run the program for the breathing activity
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long in seconds would you like for your session?  ");
        string userInput = Console.ReadLine();
        int userDuration = int.Parse(userInput);
        SetDuration(userDuration);  //can I do this?
        
    }
}