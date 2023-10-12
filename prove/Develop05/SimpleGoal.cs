public class SimpleGoal : Goal
{
    public bool _isComplete;

    //constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        //mark goal complete, return point value + bonus upon completion
        _isComplete = true;
        return _points;        
    }

    public override bool IsComplete()
    {        
        return _isComplete;     
    }
 
    public override string GetDetailsString()
    {
        //includes checkbox, short name, and description.
        // if (_isComplete == true)
        // {
        //     return $"[X] {_shortName} ({_description}) ";
        // }
        // else
        // {
        //     return $"[ ] {_shortName} ({_description}) ";    
        // }        
        return $"[{GetX()}] {_shortName} ({_description}) ";    
    }
    public override string GetX()
    {
        if (_isComplete == true)
        {
            return "X";
        }
        else 
        {
            return " ";
        }
    }


    public override string GetStringRepresentation()
    {
        // create string to be stored in a file, use delimiter ***
        string stringRepresentation = $"SimpleGoal:{_shortName}***{_description}***{_points}***{_isComplete}";
        return stringRepresentation;        
    }
}