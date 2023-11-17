using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        bool quit = true;
        List<string> temp = new();

        do
        {

            DisplayMenu();
            string prompt = Console.ReadLine();
            int intPrompt = int.Parse(prompt);



            if (intPrompt == 1)
            {



                GoalType();
                string goalPrompt = Console.ReadLine();
                int intGoalPrompt = int.Parse(goalPrompt);

                if (intGoalPrompt == 1 || intGoalPrompt == 2)
                {
                    Console.Write("What is the name of the goal? ");
                    string nameGoal = Console.ReadLine();
                    Console.Write("What is a short description for the goal? ");
                    string descriptionGoal = Console.ReadLine();
                    Console.Write("How much points is the goal associated with? ");
                    string stringPoint = Console.ReadLine();
                    int pointGoal = int.Parse(stringPoint);
                    Console.Write("\n");

                    if (intGoalPrompt == 1)
                    {
                        SimpleGoals simple = new(nameGoal, descriptionGoal, pointGoal);
                        TempSave(simple.TempString(), temp);


                    }
                    if (intGoalPrompt == 2)
                    {
                        EternalGoals eternal = new(nameGoal, descriptionGoal, pointGoal);
                        TempSave(eternal.TempString(), temp);

                    }


                }
                if (intGoalPrompt == 3)
                {
                    Console.Write("What is the name of the goal? ");
                    string nameGoal = Console.ReadLine();
                    Console.Write("What is a short description for the goal? ");
                    string descriptionGoal = Console.ReadLine();
                    Console.Write("How much points is the goal associated with? ");
                    string stringPoint = Console.ReadLine();
                    int pointGoal = int.Parse(stringPoint);
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string repeatString = Console.ReadLine();
                    int repeat = int.Parse(repeatString);
                    Console.Write("How much is the bonus points? ");
                    Console.Write("\n");
                    string bonusString = Console.ReadLine();
                    int bonusPoint = int.Parse(bonusString);
                    Console.Write("\n");

                    CheckListGoals checkList = new(nameGoal, descriptionGoal, pointGoal, repeat, bonusPoint);
                    TempSave(checkList.TempString(), temp);
                }





            }

            if (intPrompt == 2)
            {
                Console.Write("\n");
                DisplayList(temp);
                Console.Write("\n");
            }

            if (intPrompt == 6)
            {
                quit = false;
            }
        } while (quit == true);

    }
    static void DisplayMenu()
    {

        Console.WriteLine("Menu Options: ");
        Console.WriteLine(" 1. Create New Goals");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
        Console.Write("Select a choice from the menu: ");
    }
    static void GoalType()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.Write("Choose what type of Goal: ");
    }


    static void TempSave(string represent, List<string> temp)
    {
        temp.Add(represent);

    }
    static void DisplayList(List<string> temp)
    {
        int index = temp.Count();
        int count = 1;
        foreach (string goal in temp)
        {
            Console.WriteLine($"{count} [ ]{goal}");
            count += 1;
        }

    }

}