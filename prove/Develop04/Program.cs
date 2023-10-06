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
        //needs a while loop so that it returns to the menu unless 4 is picked
        int userChoice = 0;
        while (userChoice != 4)
        {
            userChoice = DisplayMenu();
            
            if (userChoice == 1)
            {   
                //create a new breathing activity object
                BreathingActivity a1 = new BreathingActivity();    
                a1.Run();          
            }
            else if (userChoice == 2)
            {
                // Console.WriteLine("In choice 2.");
                // Thread.Sleep(1000);
                ReflectingActivity a2 = new ReflectingActivity();
                a2.Run();
            }
            else if (userChoice == 3)
            {
                ListingActivity a3 = new ListingActivity();
                a3.Run();
            }

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