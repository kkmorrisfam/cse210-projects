using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {   //get magic number, convert to int type
        
        // Console.Write("What is the magic number?  ");
        // string userNumber = Console.ReadLine();
        // int magicNumber = int.Parse(userNumber);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 20);

        string userInput = "";
        int userGuess = 0;
        int loopCounter = 0;

        string play = "yes";

        while (play == "yes")
        {
            do 
            {
                
                //get user guess, convert to int type
                Console.Write("Pick a number between 1 and 20. What is your guess?  ");
                userInput = Console.ReadLine();
                userGuess = int.Parse(userInput);

                if (magicNumber > userGuess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < userGuess)
                {
                    Console.WriteLine("Lower");
                }
                else if (magicNumber == userGuess)
                {
                    Console.WriteLine("Correct!");
                }

                loopCounter++;

            } while (magicNumber != userGuess);

            Console.Write("Do you want to play again?  ");
            play = Console.ReadLine();
        }    

        Console.WriteLine($"You made {loopCounter} guess(es).");

    }
}