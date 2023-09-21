using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        Console.WriteLine("GetRandomPrompt() called. ");
        string aPrompt = "Random Prompt";
        return aPrompt;
    }
    public void prompt()
    {
        Console.WriteLine("Hello PromptGenerator World!");
    }

    public PromptGenerator()
    {

    }
}