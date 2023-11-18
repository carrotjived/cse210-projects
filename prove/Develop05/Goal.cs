using System.IO;
public class Goal
{
    private string _name;
    private string _description;
   
    private bool _isComplete = false;
    private int _points;



    
    
    
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public virtual int RecordEvent()
    {
        int recordPoints = 0;
        return recordPoints;
    }
    public virtual string Complete()
    {
        string sign = "";
        return sign;
    }
    public virtual bool IsComplete()
    {
        return _isComplete;
    }

   
    
    
    public int GetPoints()
    {
        return _points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }
    

    public virtual string TempString()
    {
        return "";
    }

    public virtual string GetStringPresentation()
    {
        return "";
    }

    

    
}






