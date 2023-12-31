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
                LoadGoals();
            }
            // Record Event
            else if (userMainInput == 5)
            {
                RecordEvent();
            }
            else if (userMainInput == 6)
            {
                DeleteGoal();
            }


        } while (userMainInput != 7);

    }

    public void DisplayPlayerInfo()
    {
        
        //Displays the players current score
        Console.WriteLine($"You now have {_score} points.");
    }

    public void ListGoalNames() 
    {
        //List the names of each of the goals
        int i = 1;
        foreach (Goal item in _goals)
        {
            Console.WriteLine($"{i}. {i.ToString()}. {item.GetName()}");
            i++;
        }
    }

    public void ListGoalDetails()
    {
        //lists the details of each goal (including the checkbox of whether it is complete)
        foreach (Goal item in _goals)
        {
            Console.WriteLine(item.GetDetailsString());
            // Console.WriteLine(item.GetType());  //prints the goal type: SimpleGoal etc.
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
        int points = _goals[userRecordInput].RecordEvent(); //call RecordEvent on object in list at index.
        _score += points;   

        Console.WriteLine($"Congratulations! You have earned {points} points!");
        // Console.WriteLine($"Your now have {_score} points total.");

        DisplayPlayerInfo();
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
        // Goal g1;  //can declare this here, but then when I create objects with child constructor, object doesn't
                    // have the functionality of the child object, only the parent. Can't access child variables

      
        foreach(string line in lines)
        {
            //how to skip first line?
            if (line == lines[0]) continue;  //not working thinks one is a char and one is a string
            string[] firstPass = line.Split(":");
            objectString = firstPass[0];
            parameterString = firstPass[1];
            
            
            string[] secondPass = parameterString.Split("***");
            string name = secondPass[0];
            string description = secondPass[1];
            int points = int.Parse(secondPass[2]);

            // creates object matching label            
            if (objectString == "SimpleGoal")
            {
                SimpleGoal g1 = new SimpleGoal(name, description, points);                
                if (secondPass[3] == "True")
                {
                    g1.SetIsComplete(true);
                }
                _goals.Add(g1);
            }
            
            else if (objectString == "ChecklistGoal")
            {
                int bonus = int.Parse(secondPass[3]);
                int target = int.Parse(secondPass[4]);
                int amountCompleted = int.Parse(secondPass[5]);
                ChecklistGoal g1 = new ChecklistGoal(name, description, points, target, bonus);
                g1.SetAmountCompleted(amountCompleted);
                _goals.Add(g1);
            }
            else //(objectString == "EternalGoal")
            {
                EternalGoal g1 = new EternalGoal(name, description, points);
                _goals.Add(g1);
            }
        }
     }

    public void DeleteGoal()
    {
        //asks the user which goal they want to delete
        ListGoalNames();
        Console.Write("Which goal would you like to delete?  (note: this does not remove any points earned from this goal)  ");
        string userInput = Console.ReadLine();
        int userRecordInput = int.Parse(userInput);
        userRecordInput = userRecordInput - 1; // match index numbering of list with menu number.
        //  the event by calling the RecordEvent method on that goal
        //add points to score
        // _score += _goals[userRecordInput].RecordEvent();   //call RecordEvent on object in list at index.
        _goals.Remove(_goals[userRecordInput]);
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
        Console.WriteLine("   6. Delete Goal");
        Console.WriteLine("   7. Quit");
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