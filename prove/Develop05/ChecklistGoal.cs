public class ChecklistGoal : Goal
{
    public int _amountCompleted;
    public int _target;
    public int _bonus;

    //constructor
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        //increment amount completed
        _amountCompleted ++;   
        //check to see if amount completed = target
        if (_amountCompleted == _target)
        {
            return _points + _bonus;
        }
        else
        {
            return _points;
        }
        
    }
    public override bool IsComplete()
    {
        //check to see if amount completed = target
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        // if (_amountCompleted == _target)
        // {
        //     return $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";        
        // }
        // else
        // {
        //     return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";        
        // }    

        return $"[{GetX()}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";        
    }
    public override string GetX()
    {
        if (_amountCompleted == _target)
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
        string stringRepresentation = $"ChecklistGoal:{_shortName}***{_description}***{_points}***{_bonus}***{_target}***{_amountCompleted}";
        return stringRepresentation;        
    }

}