using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public string _startYear;
    public string _endYear;

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Job()
    {

    }

    public void Display()
    {
        Console.WriteLine($"{_company} ({_jobTitle}), {_startYear} - {_endYear}");
    
    }
}

