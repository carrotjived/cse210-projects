public class CheckListGoals : Goal
{

    private int _repeat;
    private int _bonus;
    private int _index;
    private bool _isComplete;

    public CheckListGoals(string name, string description, int points, int repeat, int bonus, int index, bool isComplete) : base(name, description, points)
    {

        _repeat = repeat;
        _bonus = bonus;
        _isComplete = isComplete;
        _index = index;

    }

    public override int RecordEvent()
    {
        int points = 0;

        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!\n");
        points = GetPoints();
        IncreaseIndex();

        if (_index == _repeat)
        {
            Console.WriteLine($"Congratulations! You have earned {_bonus} bonus points!");
            points += _bonus;
            Complete();



        }
        return points;

    }

    public void IncreaseIndex()
    {
        _index += 1;
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
        string represent = $"{GetName()} ({GetDescription()}) -- Currently Completed: {_index}/{_repeat}";
        return represent;
    }

    public override string GetStringPresentation()
    {
        return $"Checklist Goal||{GetName()}||{GetDescription()}||{GetPoints()}||{_repeat}||{_bonus}||{_index}||{_isComplete}";
    }
}