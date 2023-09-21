using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
    }

 public class getRandomPrompt
{
    public getRandomPrompt()
    {
    }
    }
    //load txt file?
    //int aRandomIndex;
    //public List<Job> _jobs = new List<Job>();
    // use public if I am going to use this variable outside of this page
    //should I pass in a list through class?
    public List<string> _promptList = new List<string>  //some places online added () to end of this line.
    {
        "prompt1", "prompt2", "prompt3", "prompt5", "prompt6"
    };

    Random myRandomNum = new Random();  //creates random instance
    int aRandomIndex = myRandomNum.Next(_promptList.Count); //picks random number
    string myRandomPrompt = _promptList[aRandomIndex];
    
    ReturnTypeEncoder myRandomPrompt;
}
    
}