public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

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
        Console.Write(">");
        userInput.Add(Console.ReadLine());
        _count++;
        return userInput;
    }
    public void SetPromptList()
    {
        _prompts= new List<string>();
        
        _prompts.Add("Prompt 1");
        _prompts.Add("Prompt 2");
        _prompts.Add("Prompt 3");
        _prompts.Add("Prompt 4");
        _prompts.Add("Prompt 5");

    }

}