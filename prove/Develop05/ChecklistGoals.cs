public class CheckListGoals : Goal
{
    private int _points;
    private int _repeat;
    private int _bonus;
    private int _index = 0;
    private bool _isComplete = false;

    public CheckListGoals(string name, string description, int points, int repeat, int bonus) : base(name, description)
    {
        _points = points;
        _repeat = repeat;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        UpdatePoints(_points);
        _index += 1;
        if (_index == _repeat)
        {
            Console.WriteLine($"Congratulations! You have earned {_bonus} points!");
            UpdatePoints(_bonus);
        }
        Console.WriteLine($"You now have {GetTotalPoints()}");
    }

    public override bool IsComplete()
    {
        _isComplete = true;
        return _isComplete;
    }

     public override string TempString()
    {
        string represent = $"{GetName()} ({GetDescription()} -- Currently Completed: {_index}/{_repeat})";
        return represent;
    }
}