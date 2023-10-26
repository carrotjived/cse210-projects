using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment student = new("Sameul Bennet", "Multiplication");
        Console.Clear();
        Console.WriteLine(student.GetSummary());
        MathAssignment mathStudent = new("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathStudent.GetSummary());
        Console.WriteLine(mathStudent.GetHomeworkList());
        WritingAssignment writeStudent = new("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writeStudent.GetSummary());
        Console.WriteLine(writeStudent.GetWritingInformation());

    }
}