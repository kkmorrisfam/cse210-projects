public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<int> _randomIntPrompt = new List<int>();
    private List<int> _randomIntQuestion = new List<int>();


    //constructor
    public ReflectingActivity() : base()  //sets base Activity default constructor values
    {
        //set default values
        _name = "Reflecting";
        _description = @"This activity will help you reflect on times in your life
when you have shown strength and resilience. this will help you realize
the power you have and how you can use it in other aspects of your life.";
        SetPromptList();
        SetQuestionList();
        // _prompts = new List<string>{"Prompt 1", "Prompt 2", "Prompt 3", "Prompt 4", "Prompt 5"};
        // _questions = new List<string>{"Question 1", "Question 2", "Question 3", "Question 4", "Question 5"};
    }

    // public ReflectingActivity(string name, string description, List<string> prompts, List<string> questions) : base(name, description)
    // {
    //     _prompts = prompts;
    //     _questions = questions;
    // }

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        SetPromptList();  //set _prompts variable
        SetQuestionList();  //set _questions variable
    }

    public void Run()
    {
        
        //run the activity
        DisplayStartingMessage();
        //add to starting message?
        // Console.Clear();
        // Console.Write("Get Ready...");        
        // ShowSpinner(4);
        // Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"---{prompt}---");
        Console.Write("When you have something in mind, press enter to continue:  ");
        string userInput = Console.ReadLine();
        
        
        Console.Write("You may begin in...");
        for (int i=5; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        //loop until the list is 
        int j = 0;
        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();   //get new question
            Console.WriteLine(question);
            ShowSpinner(10);
            j++;
            if (j >= _questions.Count)  
            {
                j = 0;
                _randomIntQuestion.Clear();  //start over collecting random numbers
            }
        }

        DisplayEndingMessage();

    }
    public string GetRandomPrompt()
    {
        string randomPrompt = "";
        Random random = new Random();  
        int randomInt = -1;
        bool containsMatch = false;

        do 
        {
            randomInt = random.Next(0, _prompts.Count);  //# does not include Count

            containsMatch = _randomIntPrompt.Contains(randomInt);
            if (containsMatch == false)  //number is not in list
            {
                _randomIntPrompt.Add(randomInt);  //add random number to list
                randomPrompt = _prompts[randomInt];  //return prompt at random index
            }
        } while (containsMatch == true); //repeat if number is in list


        return randomPrompt;
    }
public string GetRandomQuestion()
    {
        string randomQuestion = "";
        Random random = new Random();  
        int randomInt = -1;
        bool containsMatch = false;

        do 
        {
            randomInt = random.Next(0, _prompts.Count);  //# does not include Count

            containsMatch = _randomIntQuestion.Contains(randomInt);
            if (containsMatch == false)  //number is not in list
            {
                _randomIntQuestion.Add(randomInt);  //add random number to list
                randomQuestion = _questions[randomInt];  //return prompt at random index
            }
        } while (containsMatch == true); //repeat if number is in list


        return randomQuestion;
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

    public void SetQuestionList()
    {
        _questions = new List<string>();
        _questions.Add("Question 1");
        _questions.Add("Question 2");
        _questions.Add("Question 3");
        _questions.Add("Question 4");
        _questions.Add("Question 5");      

    }
}