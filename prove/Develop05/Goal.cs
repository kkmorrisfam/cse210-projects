public abstract class Goal
{   
    protected string _shortName;
    protected string _description;
    protected int _points;

    //constructor
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    // public string GetDescription()
    // {
    //     return _description;
    // }
    // public int GetPoints()
    // {
    //     return _points;
    // }

    public void SetName(string name)
    {
        _shortName = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetPoints(int points)
    {
        _points = points;        
    }

    //abstract classes - no body here
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    
    //regular class
    public virtual string GetDetailsString()
    {
        //includes checkbox, short name, and description.
    
        return $"[ ] {_shortName} ({_description}) ";
    }
    public virtual string GetX()
    {
        return "X";
    }
    

}