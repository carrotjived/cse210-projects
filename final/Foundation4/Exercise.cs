public class Exercise 
{
    private DateAndTime _date;
    private int _length;

    public Exercise(int day, string month, int year,int length)
    {
        _date = new(day, month, year);
        _length =  length;
    }

    public virtual double ComputeDistance()
    {
        int distance = 0;
        return distance;
    }

    public virtual double ComputeSpeed()
    {
        int speed = 0;
        return speed;

    }

    public virtual double ComputePace()
    {
        int pace = 0;
        return pace;

    }

    public virtual string GetSummary()
    {
        string summary = "";
        return summary;
    }

    public int GetLength()
    {
        return _length;
    }

    public string GetDateAndTime()
    {
        return _date.GetDateTime();
    }



}