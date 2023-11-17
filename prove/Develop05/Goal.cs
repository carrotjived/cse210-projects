public class Goal
{
    private string _name;
    private int _points = 0;
    private List<string> _goals;
    private string _description;

    private bool _isComplete;
    private int bonus = 0;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }


    public int DisplayStatus()
    {
        return _points;
    }
    public virtual void RecordEvent()
    {
        _points = 0;
    }

    public virtual bool IsComplete()
    {
        return _isComplete = true;
    }

    
}







