using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices.Marshalling;

class Program
{
      static int DisplayMenu()
    {               
        //Display menu
        string userInput;
        int userChoice;
        Console.Clear();

        Console.WriteLine("Menu Options");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu (enter a number):  ");
        userInput = Console.ReadLine();
        userChoice = int.Parse(userInput);
        return userChoice;
    }

   
    static void Main(string[] args)
    {
        int userChoice = DisplayMenu();
        // Activity myActivity = new Activity();
        // myActivity.SetDuration(20);
        
        if (userChoice == 1)
        {   
            //create a new breathing activity object
            BreathingActivity a1 = new BreathingActivity();    
            a1.Run();
        }
        
        
        
        
        
        
        
        
        // myActivity.DisplayStartingMessage();
        // Console.WriteLine();
        // myActivity.ShowSpinner(10);
        // Console.WriteLine();
        
        // Console.Write(" Breath in...");
        // myActivity.ShowCountDown(5);
        // Console.WriteLine();
        // myActivity.DisplayEndingMessage();

        



    }
}

// internal class BreathingActivity
// {
// }