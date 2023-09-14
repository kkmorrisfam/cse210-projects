using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?  ");
        string userInput = Console.ReadLine();
        int gradePercent = int.Parse(userInput);
        string letterGrade;
        int remainder = gradePercent % 10;  //get the remainder to determine sign
        string sign = "";

        if (gradePercent >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercent >= 80)
        {
            letterGrade = "B";
        }
       else if (gradePercent >=70)
        {
            letterGrade = "C";
        }
       else if (gradePercent >= 60)
        {
            letterGrade = "D";
        }
        else 
        {
            letterGrade = "F";
        }
        //what's your sign
        if (remainder >=7)
        {
            sign = "+";    
        }
        else if (remainder <= 3)
        {
            sign = "-";
        }
        //negate sign if A+ or F range
        if (gradePercent >96 || gradePercent < 60)
        {
            sign = "";
        } 
        
        Console.WriteLine ($"Your grade is {letterGrade}{sign}");
        if (gradePercent >= 70)
        {
            Console.WriteLine("Awesome! You passed the class.");

        }
        else
        {
            Console.WriteLine("Awe man you didn't pass the class! Better luck next time.");
        }
    }
}