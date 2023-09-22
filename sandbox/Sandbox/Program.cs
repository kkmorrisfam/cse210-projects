//program with Writing Demo Week 2

using System;
using System.Collections.Generic; // for Lists creation
using System.IO; //for StreamWriter

class Program
{
    static void Main(string[] args)
    {
    
        // Person p1 = new Person();
        // p1._firstName = "Mary";
        // p1._lastName = "Smith";
        // p1._age = 25;

        // Person p2 = new Person();
        // p2._firstName = "John";
        // p2._lastName = "Watkins";
        // p2._age = 30;

        // List<Person> people = new List<Person>();
        // people.Add(p1);
        // people.Add(p2);

        // foreach (Person p in people)
        // {
        // Console.WriteLine(p._firstName); 
        // }

        // SaveToFile(people);  //call method

        List<Person> newPeople = ReadFromFile();
        foreach (Person p in newPeople)
        {
            Console.WriteLine(p._lastName);
        }
    }

    public static void SaveToFile(List<Person> people)
    {
        // giving notice to screen
        Console.WriteLine("Saving to file..."); 
        // create file variable with filename
        string filename = "people.txt";
        
        //opens and closes file with "using" and StreamWriter object
        //as soon as program leaves this code block, file will be closed     
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Person p in people)
            {
                outputFile.WriteLine($"{p._firstName},{p._lastName},{p._age}"); 
            }    
        }

    }

    public static List<Person> ReadFromFile()
    {
        Console.WriteLine("Reading List from file...");
        List<Person> people = new List<Person>();
        string filename = "people.txt";

        //read whole file at once and put into string Array
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // Console.WriteLine(line);      
            //line will be split by comma like: "Marry,Smith,25"          
            string[] parts = line.Split(",");

            // parts[0] = Mary
            // parts[1] = Smith
            // parts[2] = 25

            Person newPerson = new Person();
            newPerson._firstName = parts[0];
            newPerson._lastName = parts[1];
            newPerson._age = int.Parse(parts[2]);

            people.Add(newPerson);
        
        }
        return people;

    }


  
}













// using System;
// using System.Reflection.Metadata.Ecma335;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Sandbox World!");
//     }

//  public class getRandomPrompt
// {
//     public getRandomPrompt()
//     {
//     }
//     }
//     //load txt file?
//     //int aRandomIndex;
//     //public List<Job> _jobs = new List<Job>();
//     // use public if I am going to use this variable outside of this page
//     //should I pass in a list through class?
//     public List<string> _promptList = new List<string>  //some places online added () to end of this line.
//     {
//         "prompt1", "prompt2", "prompt3", "prompt5", "prompt6"
//     };

//     Random myRandomNum = new Random();  //creates random instance
//     int aRandomIndex = myRandomNum.Next(_promptList.Count); //picks random number
//     string myRandomPrompt = _promptList[aRandomIndex];
    
//     ReturnTypeEncoder myRandomPrompt;
// }
    
// }