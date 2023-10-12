public class EternalGoal : Goal
{
    //no variables?

    //constructor
    // public EternalGoal()
    // {
    //     _shortName = "";
    //     _description = "";
    //     _points = 0;        
    // }
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        //never complete, but must define abstract method in derived class
        return false;
    }
    public override string GetStringRepresentation()
    {
            // create string to be stored in a file, use delimiter ***
        string stringRepresentation = $"EternalGoal:{_shortName}***{_description}***{_points}";
        return stringRepresentation;  
    }

}