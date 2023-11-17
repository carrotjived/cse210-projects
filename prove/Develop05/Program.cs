using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = true;
        
        do
        {
            Console.Clear();
            DisplayMenu();
            string prompt = Console.ReadLine();
            int intPrompt = int.Parse(prompt);


            if (intPrompt == 1)
            {
                GoalType();
                string goalPrompt = Console.ReadLine();
                int intGoalPrompt = int.Parse(goalPrompt);

                if (intGoalPrompt == 1)
                {

                }

            }

            if (intPrompt == 6)
            {
                quit = false;
            }
        } while (quit == true);

    }
    static void DisplayMenu()
    {
        Console.WriteLine($"You have  points.");
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
    }

    

}