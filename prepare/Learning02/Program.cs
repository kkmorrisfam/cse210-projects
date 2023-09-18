using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        myResume._name = "Kerri Morris";
                
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = "2005";
        job1._endYear = "2013";
        
        Job job2 = new Job();
        job2._company = "WordPerfect";
        job2._jobTitle = "Software Engineer";
        job2._startYear = "1995";
        job2._endYear = "1998";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        myResume.DisplayName();
        myResume.DisplayJob();
        
    }


}