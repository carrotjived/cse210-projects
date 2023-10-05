using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


List<string> questions = new()
{
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"
};



Console.WriteLine("Welcome to Journal Program!");
int i = 0;
Journal journal = new();


do
{
    Console.WriteLine("Please select one of the following choices: ");
    Console.WriteLine("1. Write");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Load");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Quit");
    Console.Write("What would you like to do? ");

    string ask = Console.ReadLine();
    int promptIndex = int.Parse(ask);
    Console.WriteLine();




    if (promptIndex == 1)
    {
        //Date
        DateTime currentTime = DateTime.Now;
        string dateText = currentTime.ToString("HH:mm dd MMMM yyyy");

        //Prompt Question
        PromptGenerator showPrompt = new()
        {
            _questions = questions
        };
        showPrompt.DisplayPromptQuestion();
        //Entry
        Console.Write(">>");
        string entry = Console.ReadLine();


        //Assign
        Entry write = new()
        {
            _date = dateText,
            _promptQuestion = showPrompt._returnQuestion,
            _entry = entry
        };
        journal._entries.Add(write);

        Console.WriteLine();



    }
    else if (promptIndex == 2)
    {
        journal.DisplayEntries();
        
        

    }

    else if (promptIndex == 3)

    {
        Console.WriteLine("\nWhat is the filename? ");
        string userFile = Console.ReadLine();
        Console.WriteLine();

        if (File.Exists(userFile)) 
        {
            journal._loadFileName = userFile;
            List<Entry> loadedFile = journal.LoadFile();
            
            journal._temporary = loadedFile;
            Console.WriteLine("File Loaded.");
        }

        else 
        {
            Console.WriteLine("File does not exist.");
        }
        Console.WriteLine();

    }

    else if (promptIndex == 4)
    {
        //filename prompt
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();
        journal._fileName = filename;

        journal.SaveToFile(journal._entries);
        Console.WriteLine($"\nFile Saved as '{filename}'\n");

        journal._entries.Clear();





    }
    else if (promptIndex == 5)

    {
        i = 5;
    }

    else
    {
        Console.WriteLine("Invalid Syntax\n");
    }




} while (i != 5);

