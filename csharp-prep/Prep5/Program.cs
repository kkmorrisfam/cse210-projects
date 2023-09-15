using System;

class Program
{
    
    //Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    
    //Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name:  ");
        string userName = Console.ReadLine();
        return userName;
    }

    //Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number.  ");
        string userInput = Console.ReadLine();
        int favoriteNumber = int.Parse(userInput);
        return favoriteNumber;
    }

    //Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int userNumber)
    {
        int squared = userNumber * userNumber;
        return squared;
    }

    //Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string userName, int number)
    {
        Console.WriteLine($"{userName} the square of your number is {number}.");
    }
    static void Main(string[] args)
    {        
        DisplayWelcome();
        string userName1 = PromptUserName();
        int userNumber1 = PromptUserNumber();        
        int squareNumber1 = SquareNumber(userNumber1);
        DisplayResult(userName1, squareNumber1);
    }

}