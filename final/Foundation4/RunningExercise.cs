public class RunningExercise : Exercise

{
    private double _distance;
    public RunningExercise( double distance, int day, string month, int year,int length) : base(day, month, year, length)
    {
        _distance = distance;
    }

    public override double ComputeDistance()
    {   
        double distance = Math.Round(_distance, 1);
        return distance;
    }

    public override double ComputeSpeed()
    {
        
        double speed = Math.Round(((_distance/GetLength()) * 60),1);
        return speed;

    }

    public override double ComputePace()
    {
        double pace = Math.Round((GetLength() / _distance),1);
       
        return pace;

    }

    public override string GetSummary()
    {
        
        return $"{GetDateAndTime()} ({GetLength()} min) - Distance: {ComputeDistance()} km, Speed: {ComputeSpeed()} kph, Pace: {ComputePace()} min per mile.\n";
    }


}