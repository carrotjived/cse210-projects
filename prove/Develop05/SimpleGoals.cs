public class SimpleGoals : Goal
{
   
    private bool _isComplete;
    public SimpleGoals(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
       _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        int points = 0;

        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!\n");
        points = GetPoints();
        Complete();

        return points;
        

    }

     public override string Complete()
    {
        _isComplete = true;
        string sign = "X";
        return sign;
    }
    public override bool IsComplete()
    {
        return _isComplete;
        

    }

    public override string TempString()
    {
        string represent = $"{GetName()} ({GetDescription()})";
        return represent;
    }
    public override string GetStringPresentation()
    {
        return $"Simple Goal||{GetName()}||{GetDescription()}||{GetPoints()}||{_isComplete}";
    }
}