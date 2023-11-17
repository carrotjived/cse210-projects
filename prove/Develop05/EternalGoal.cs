public class EternalGoals : Goal
{
    private int _points;
    private bool _isComplete = false;

    public EternalGoals(string name, string description, int points) : base(name, description)
    {
        _points = points;
    }

    public override void RecordEvent()
    {
       Console.WriteLine($"Congratulations! You have earned {_points} points!");
        UpdatePoints(_points);
        Console.WriteLine($"You now have {GetTotalPoints()}");
    }

    public override bool IsComplete()
    {
        _isComplete = true;
        return _isComplete;
    }
     public override string TempString()
    {
        string represent = $"{GetName()} ({GetDescription()})";
        return represent;
    }
}