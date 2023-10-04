using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Mary Walters", "European History");
        
        Console.WriteLine(myAssignment.GetSummary());
        Console.WriteLine();

        MathAssignment myMathAssignment = new MathAssignment("Roberto Rodriguez", "Fraction", "Section 7.3", "Problems 8-19");

        Console.WriteLine(myMathAssignment.GetSummary());
        Console.WriteLine();
        
        WritingAssignment myWritingAssignment = new WritingAssignment("Mary Walters", "Eureopean History", "The Causes of World War II");

        Console.WriteLine(myWritingAssignment.GetSummary());
        Console.WriteLine(myWritingAssignment.GetWritingInformation());
    }
}