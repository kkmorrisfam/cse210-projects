using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    //constructor
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int userMainInput = -1;
        // string userMainChoice;
        // int userGoalInput = -1;
        // string userGoalChoice;
        
        
        //run program
        do 
        {
            userMainInput = RunMenu();           
            
            // Create New Goal
            if (userMainInput == 1)
            {
                CreateGoal();  
            }
            //list goals
            else if (userMainInput == 2)
            {
                ListGoalDetails();
            }
            //save goals
            else if (userMainInput == 3)
            {
                 SaveGoals();   
            }
            // Load Goals
            else if (userMainInput == 4)
            {

            }
            // Record Event
            else if (userMainInput == 5)
            {
                RecordEvent();

            }


        } while (userMainInput != 6);

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine("");
        //Displays the players current score
    }

    public void ListGoalNames() 
    {
        //List the names of each of the goals
        int i = 1;
        foreach (Goal item in _goals)
        {
            Console.WriteLine($" {i.ToString()}. {item.GetName()}");
            i++;
        }
    }

    public void ListGoalDetails()
    {
        //lists the details of each goal (including the checkbox of whether it is complete)
        foreach (Goal item in _goals)
        {
            Console.WriteLine(item.GetDetailsString());
        }
        
        

    }

    public void CreateGoal()
    {
        //Display Goal menu  get user choice
         int userGoalInput = RunGoalMenu();
        //asks the user for the information about a new goal. Then, creates the goal and adds it to the list.       
        Console.Write("What is the name of your goal?  ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it?  ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?  ");
        string userInput = Console.ReadLine();
        int points = int.Parse(userInput);

        if (userGoalInput == 1)
        {
            //create SimpleGoal object
            //upon creation isComplete is false
            SimpleGoal s1 = new SimpleGoal(name, description, points);
            //add goal to list
            _goals.Add(s1);
        }
        //Create Eternal Goal
        else if (userGoalInput == 2)
        {
            EternalGoal e1 = new EternalGoal(name, description, points);
            _goals.Add(e1);
        }
        //Checklist Goal
        else if (userGoalInput == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
            string input = Console.ReadLine();
            int target = int.Parse(input);
            Console.Write("What is the bonus for accomplishing it that many times?  ");
            input = Console.ReadLine();
            int bonus = int.Parse(input);

            ChecklistGoal c1 = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(c1);
        } 

    }
    public void RecordEvent()
    {
        //asks the user which goal they have done
        ListGoalNames();
        Console.Write("Which goal did you accomplish?  ");
        string userInput = Console.ReadLine();
        int userRecordInput = int.Parse(userInput);
        userRecordInput = userRecordInput - 1; // match index numbering of list with menu number.
        // records the event by calling the RecordEvent method on that goal
        //add points to score
        _score += _goals[userRecordInput].RecordEvent();   //call RecordEvent on object in list at index.
        
        //how do I test if the object at the index is of type ChecklistGoal?


    }

    public void SaveGoals()
    {
        //get filename
        Console.Write("Enter the name of the file to save:  ");
        string aFileName = Console.ReadLine();
        //saves the list of goals to a file.
                
        using(StreamWriter outputFile = new StreamWriter(aFileName))
        {
            //gets points and adds to first line of file
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                //calls GetStringRepresentation() for each goal and adds each to a line in the file
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("Enter the name of the file to open:  ");
        string aFileName = Console.ReadLine();

        //loads all lines from a file. each line is a string
        string[] lines = System.IO.File.ReadAllLines(aFileName);
        //gets first line, transfers it to score variable
        _score = int.Parse(lines[0]);
        //create another string[] gets each line of code, parses information out by colon
        string objectString;
        string parameterString;
        Goal g1;

      
        foreach(string line in lines)
        {
            //how to skip first line?
            if (line == line[0]) continue;  //not working thinks one is a char and one is a string
            string[] firstPass = line.Split(":");
            objectString = firstPass[0];
            parameterString = firstPass[1];
            
            
            string[] secondPass = parameterString.Split("***");
            string name = secondPass[0];
            string description = secondPass[1];
            int points = int.Parse(secondPass[2]);
            
            if (objectString == "SimpleGoal")
            {
                g1 = new SimpleGoal(name, description, points);
            }
            
            else if (objectString == "ChecklistGoal")
            {
                int target = int.Parse(secondPass[3]);
                int bonus = int.Parse(secondPass[4]);
                g1 = new ChecklistGoal(name, description, points, target, bonus);
            }
            else //(objectString == "EternalGoal")
            {
                g1 = new EternalGoal(name, description, points);
            }
            

            _goals.Add(g1);
        }

        // foreach(string line in firstPass)
        // {
        //     string[] secondPass = line.Split("***");
        // }
        //1. creates object matching label
        //2. adds name to _name, description to _description, etc.
        //3. adds true/false to _isComplete if SimpleGoal
        //4. adds info to Checklist goal
    }

    public int RunMenu()
    {   Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");
        Console.WriteLine("   5. Record Event");
        Console.WriteLine("   6. Quit");
        Console.Write("Select a choice from the menu:  ");
        
        string userMainChoice = Console.ReadLine();
        return int.Parse(userMainChoice);
    }

    public int RunGoalMenu()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.Write("Which type of goal would you like to create?  ");

        string userGoalChoice = Console.ReadLine();
        return int.Parse(userGoalChoice);
    }
}