//program with Week 4

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        // Thread.Sleep(2000);

        // Console.WriteLine("Done");
        //different lines
        for (int i=5; i>0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }

        //all on same line
        for (int i=5; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
        }
        Console.WriteLine(); //move to next line
        //over same space
        for (int i=5; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");    // "\b" is the back arrow key, space, then another back arrow
        }
        
        Console.WriteLine(); //move to next line
        //animation, all on same line
        for (int i=5; i>0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        
        Console.WriteLine(); //move to next line
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

        foreach (string s in animationList)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(20);

        // while (DateTime.Now < endTime)
        // {
        //     Console.Write(".");
        //     Thread.Sleep(1000);
        // }

        Console.WriteLine("final");

        int j = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationList[j];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            j++;
            if (j >= animationList.Count)
            {
                j = 0;
            }
        }



        Console.WriteLine("Done");
        // Console.WriteLine(4);
        // Thread.Sleep(1000);
        // Console.WriteLine(3);
        // Thread.Sleep(1000);
        // Console.WriteLine(2);
        // Thread.Sleep(1000);
        // Console.WriteLine(1);
        // Thread.Sleep(1000);
    }

}
    
 