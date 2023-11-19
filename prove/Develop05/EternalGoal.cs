public class EternalGoals : Goal
{

    

    public EternalGoals(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete)
    {

    }

    public override int RecordEvent()
    {
        int points = 0;
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!\n");
        points = GetPoints();
        SetStatus(IsComplete());

        return points;



    }
     public override string Complete()
    {

        string sign = "X";
        return sign;
    }
    public override bool IsComplete()
    {
        bool isComplete = GetStatus();
        isComplete = true;
        return isComplete;
    }
    
    public override string TempString()
    {
        string represent = $"{GetName()} ({GetDescription()})";
        return represent;
    }

    public override string GetStringPresentation()
    {
        return $"Eternal Goal||{GetName()}||{GetDescription()}||{GetPoints()}||{GetStatus()}";
    }
}