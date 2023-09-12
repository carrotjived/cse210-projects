using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Grade Percentage: ");
        string gradePrompt = Console.ReadLine();
        int grade = int.Parse(gradePrompt);

        int remain = grade%10;

        string finalGrade = "";

        string sign = "";

        string displayGrade = "";

        if (grade>=90)
        {
            finalGrade = "A";
        }
        else if (grade>=80)
        {
            finalGrade = "B";
        }
        else if (grade>=70)
        {
            finalGrade = "C";
        }
        else if (grade>=60)
        {
            finalGrade = "D";
        }
        else if (grade<60)
        {
            finalGrade = "F";
        }
        else 
        {
            Console.WriteLine("Incorrect Grade!");
        }
    
        if (remain>=7)
        {
            sign = "+";
        }
        else {
            sign = "-";
        }

        displayGrade = finalGrade + sign;
        
        if (displayGrade == "A+")
        {
            displayGrade = "A";
        }
        else if (displayGrade == "F+" || displayGrade == "F-")
        {
            displayGrade = "F";
        }
        
        Console.WriteLine($"Your grade is: {displayGrade}");


        if (grade>=70)
        {
            Console.WriteLine("Congratulations you have passed!");
        }
        else {
            Console.WriteLine("Life is not yet over! You can do better!");
        }
        
    }
}