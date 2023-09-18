using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // public Resume()
    // {

    // }

    public void DisplayName()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Employement: ");
        Console.WriteLine();
    }
    public void DisplayJob()
    {
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}