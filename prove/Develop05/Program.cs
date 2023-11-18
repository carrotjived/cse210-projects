using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        bool quit = true;
        
       

        Tracker tracker = new();

        

        do
        {
            
            tracker.DisplayLevel();

            tracker.DisplayMenu();
            string prompt = Console.ReadLine();
            int intPrompt = int.Parse(prompt);



            if (intPrompt == 1)
            {



                tracker.GoalType();
                string goalPrompt = Console.ReadLine();
                int intGoalPrompt = int.Parse(goalPrompt);

                tracker.CreateGoal(intGoalPrompt);


            }

            if (intPrompt == 2)
            {   
                tracker.DisplayGoals();
            }

            if (intPrompt == 3)
            {
               tracker.SaveToFile();
            }

            if (intPrompt == 4)
            {
                tracker.LoadFile();
            }

            if (intPrompt == 5)
            {
                tracker.RecordEvents();

            }

            if (intPrompt == 6)
            {
                quit = false;
            }

            if (intPrompt>6||intPrompt<0)
            {
                Console.WriteLine("\nIncorrect Prompt");
            }

        } while (quit == true);

    }
   
   
}


