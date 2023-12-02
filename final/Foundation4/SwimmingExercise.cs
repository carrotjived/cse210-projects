public class SwimmingExercise : Exercise
{
    private double _laps;

    public SwimmingExercise(double laps, int day, string month, int year,int length) : base(day, month, year, length)
    {
        _laps = laps;
    }

     public override double ComputeDistance()
    {
        double distance = Math.Round((_laps * 50 / 1000),1);
        return distance;
    }

    public override double ComputeSpeed()
    {
        
        double speed = Math.Round(((ComputeDistance()/GetLength()) * 60), 1);
        return speed;

    }

    public override double ComputePace()
    {
        double pace = Math.Round((GetLength() / ComputeDistance()),1);
       
        return pace;

    }

    public override string GetSummary()
    {
        
        return $"{GetDateAndTime()} ({GetLength()} min) - Distance: {ComputeDistance()} km, Speed: {ComputeSpeed()} kph, Pace: {ComputePace()} min per mile.\n";
    }

}