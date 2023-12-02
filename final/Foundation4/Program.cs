using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Exercise> exercises = new();

        RunningExercise running = new(3, 03, "November", 2023, 30);
        SwimmingExercise swimming = new(5, 04, "November", 2023, 45);
        CyclingExercise cycling = new(12, 05, "November", 2023, 60);
        exercises.Add(running);
        exercises.Add(swimming);
        exercises.Add(cycling);

        foreach (Exercise exercise in exercises)
        {
            Console.WriteLine(exercise.GetSummary());
        }
    
    }
}