using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        // Console.WriteLine("GetRandomPrompt() called. ");
        _prompts.Add("What was the best thing that happened to you today.");
        _prompts.Add("Describe your day from the perspective of a child.");
        _prompts.Add("Describe your day from the perspective of a cat.");
        _prompts.Add("Describe your day from the perspective of a dog.");
        _prompts.Add("If your life were a TV show, who whould be the villan and who would be the superhero?");
        _prompts.Add("Was there a time this week where you felt like a side-kick in someone else's story?");
        _prompts.Add("Was there a time today or this week where you felt strong emotion?");
        _prompts.Add("Who do you know you should forgive, but you haven't yet? And why?");
        
        //create random object
        Random rNum = new Random();

        // get a random number between 0 and the length of the list.
        int rIndex = rNum.Next(0, _prompts.Count);

        // get the prompt at the randomly chosen index        
        string aPrompt = _prompts[rIndex];
        //return prompt
        return aPrompt;
    }
    
    public PromptGenerator()
    {

    }
}