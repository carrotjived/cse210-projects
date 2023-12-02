public class CyclingExercise : Exercise
{
    private double _speed;
    public CyclingExercise(double speed, int day, string month, int year,int length) : base(day, month, year, length)
    {
        _speed = speed;
    }

     public override double ComputeDistance()
    {
        double distance = Math.Round((_speed * GetLength()/60), 1);

        return distance;
    }

    public override double ComputeSpeed()
    {
        
        double speed = Math.Round(_speed,1);
        return speed;

    }

    public override double ComputePace()
    {
        double pace = Math.Round((60/_speed),1);
       
        return pace;

    }

    public override string GetSummary()
    {
        
        return $"{GetDateAndTime()} ({GetLength()} min) - Distance: {ComputeDistance()} km, Speed: {ComputeSpeed()} kph, Pace: {ComputePace()} min per mile.\n";
    }

}