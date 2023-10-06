public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private List<string> _userResponses;

    //constructor

    public ListingActivity() : base()
    {
        // set default values
        _name = "Listing";
        _description = @"This activity will help you reflect on the good things in your life by having you list
as many things as you can in a certain area.";
        _count = 0;
        SetPromptList();
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        GetRandomPrompt();   //this function prints to screen
        Console.Write("You may begin in...");
        ShowCountDown(5);
        Console.WriteLine();
        _userResponses = GetListFromUser(); 
        Console.WriteLine($"You listed {_count.ToString()} items!");
        Console.WriteLine();
        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        string randomPrompt = "";
        Random random = new Random();          
        int randomInt = random.Next(0, _prompts.Count);
        randomPrompt = _prompts[randomInt];
        Console.WriteLine($"---{randomPrompt}---");
    }

    public List<string> GetListFromUser()
    {
        List<string> userInput = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        
        //get prompts for duration 
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            userInput.Add(Console.ReadLine());
            _count++;
        }
        return userInput;
    }
    public void SetPromptList()
    {
        _prompts= new List<string>();
        
        _prompts.Add("Who are the people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
} //end ListingActivity class