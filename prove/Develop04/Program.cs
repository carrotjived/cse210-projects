using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine(" 1. Start Breathing Activity");
        Console.WriteLine(" 2. Start Reflecting Activity");
        Console.WriteLine(" 3. Start Listing Activity");
        Console.WriteLine(" 4. Quit");
        Console.Write("Select a choice from the menu: ");





        string stringPrompt = Console.ReadLine();
        int prompt = int.Parse(stringPrompt);

        Activity activity = new(prompt);
        
        activity.DisplayStartingMessage();
        
        string durationString = Console.ReadLine();
        int duration = int.Parse(durationString);
        Activity specificActivity = new(prompt, duration);
        specificActivity.RunActivity();
        
       








    }

}