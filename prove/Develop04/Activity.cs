public class Activity
{
    //attributes
    protected string _name;
    protected string _description;
    private int _duration;
    
    //constructors
   public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 50;  //set default value
       
    }
    
    public Activity()
    {
        //set default values
        _name = "Chosen";
        _description = "This activity will help you.";
        _duration = 50;
    }
 
    //methods
    public void DisplayStartingMessage()
    {
        //do I just do Console.WriteLine?   
        //Is the message the same?  yes and no, name and description in constructor
        // message includes description, name and duration from constructor
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        //do I want to add prompt for duration here?  Is it the same in all start messages?
        Console.WriteLine();
        Thread.Sleep(5000);
        Console.Write("How long in seconds would you like for your session?  ");
        string userInput = Console.ReadLine();
        _duration = int.Parse(userInput);  //set duration value to user choice        
        Thread.Sleep(2000);        

        Console.Clear();
        Console.Write("Get Ready...");        
        ShowSpinner(4);
        Console.WriteLine();

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        Console.WriteLine();
        Thread.Sleep(2000);
        Console.WriteLine($"You have completed another {_duration.ToString()} seconds of the {_name} Activity");
        ShowSpinner(10);  
    }
    public void ShowSpinner(int seconds)
    {
            //animation 
        List<string> animationList = new List<string>();
        animationList.Add("|");
        animationList.Add("/");
        animationList.Add("-");
        animationList.Add("\\");    //because backplash is an escape character, to say I want to use the next char as a char
        animationList.Add("|");
        animationList.Add("/");
        animationList.Add("-");
        animationList.Add("\\");     //must use two backsplashes to use the backsplash as a char

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int j = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationList[j];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            j++;
            if (j >= animationList.Count)
            {
                j = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {               
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");    // "\b" is the back arrow key, space, then another back arrow
        }
    }
    

    public void SetDuration(int duration)
    {
        _duration = duration;   
    }
    public int GetDuration()
    {
        return _duration;
    }


}