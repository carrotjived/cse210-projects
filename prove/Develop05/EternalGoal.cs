public class EternalGoals : Goal
{

    private bool _isComplete = false;

    public EternalGoals(string name, string description, int points) : base(name, description, points)
    {

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
        return $"Eternal Goal||{GetName()}||{GetDescription()}||{GetPoints()}";
    }
}