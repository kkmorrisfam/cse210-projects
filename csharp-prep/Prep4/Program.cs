using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        //declare variables to be used later.
        List<int> numbersList = new List<int>();
        string userInput = "";
        int userNumber =-1;
        int maxNumber = -1;
        float avgNumber = 0;
        float total = 0;
        int smallestPositive = 200000000;

        //Introduce the program for the user.
        Console.WriteLine("Enter a list of numbers. Type 0 when finished. ");

        //while user does not type "0" ask for a number and add it to the list.
        
        while (userInput != "0")
        {
            Console.Write("Enter a number:  ");
            userInput = Console.ReadLine();
        
        //keep a running total of all of the numbers before user types in "0"
            if (userInput !="0")
            {
                userNumber = int.Parse(userInput);           
                numbersList.Add(userNumber);
                total = total + userNumber;
            }
        }

        for (int i = 0; i < numbersList.Count; i++)
        {
            //find largest number in list
            int number = numbersList[i];
            if (number > maxNumber)
            {
                maxNumber = numbersList[i];
            }
            //find smallest positive number in list
            if (number > 0)
            {
                if (number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }
        
        }
        //compute and print to screen
        avgNumber = total / numbersList.Count;
        Console.WriteLine($"The sum is:  {total}");
        Console.WriteLine($"The average is:  {avgNumber}");
        Console.WriteLine($"The max is:  {maxNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        //sort list
        numbersList.Sort();
        //print to screen as sorted list
        for (int i = 0; i < numbersList.Count; i++)
        {
            Console.WriteLine(numbersList[i]);
        }
    }
}