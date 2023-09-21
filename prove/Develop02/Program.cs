using System;
using System.IO;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    
    static void DisplayMenu()
    {               
        //Display menu
        Console.WriteLine("Please select one of the following choices.");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        
    }

        static int PromptUserChoice()
    {
        Console.Write("What would you like to do? (enter a number):  ");
        string userInput = Console.ReadLine();
        int myChoice = int.Parse(userInput);
        return myChoice;
    }


    static void Main(string[] args)
    {
        int userChoice = -1;
        string fileName;
        Journal myJournal = new Journal();  //create new Journal object
        //create new instance of Entry object
        Entry myEntry = new Entry();
       
        DisplayWelcome();

        do 
        {
            DisplayMenu();
            userChoice = PromptUserChoice();         

            //Write Entry
            if (userChoice == 1)
            {                
                //set date
                DateTime theCurrentTime = DateTime.Now;
                myEntry._date = theCurrentTime.ToShortDateString();
                             
                //get randomPrompt
                myEntry._promptText = "Display Random Prompt:  "; // placeholder - put random prompt
                
                //display randomPrompt
                Console.WriteLine(myEntry._promptText);
                //get user input - _entry string variables
                myEntry._entryText = Console.ReadLine();

                //add to Journal
                myJournal.AddEntry(myEntry);

            }

            //Display Entry
            else if (userChoice == 2)
            {
                //call journal DisplayAll(filename) method; pass filename (type-string); return void
                myJournal.DisplayAll();

            }
            //Load file
            else if (userChoice == 3)
            {
                //call journal LoadFromFile(filename) method; pass filename (type-string); return void
                Console.Write("What is the filename?  ");
                fileName = Console.ReadLine();
                myJournal.LoadFromFile(fileName);
            }
            //Save entry to File
            else if (userChoice == 4)
            {
                Console.Write("What is the filename?  ");
                fileName = Console.ReadLine();
                myJournal.SaveToFile(fileName);                
            }
 

        } while (userChoice != 5);


    }
}