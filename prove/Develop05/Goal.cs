using System.IO;
public abstract class Goal
{
    private string _name;
    private string _description;
    private int _totalPoints;


    

    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public int GetTotalPoints(){
        return _totalPoints;
    }
    public void SetTotalPoints(int points)
    {
        _totalPoints = points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }
    public void UpdatePoints(int points)
    {
        _totalPoints += points;
    }

    public abstract string TempString();

    

    
}






