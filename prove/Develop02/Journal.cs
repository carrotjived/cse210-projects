using System;
using System.IO;
using System.Text;


public class Journal 
{
    public List<Entry> _entries = new();
    public string _fileName;
    public List<Entry> _temporary = new();
    public string _loadFileName;


    public void DisplayEntries () 


    {
        Console.WriteLine();
        Console.WriteLine("1. Display latest entry");
        Console.Write("2. Display from loaded file\n" );
        string displayPrompt = Console.ReadLine();
        int displayPromptIndex = int.Parse(displayPrompt);
        
        
        if (displayPromptIndex == 1)
        {
            if (_entries.Count == 0) 
                 {
                    Console.WriteLine("Latest entry has been saved. Refer to 'Display from loaded file");
                    Console.WriteLine();
                }

            else 
            {
                foreach (Entry entries in _entries) 
                    {
                        Console.WriteLine();
                        entries.DisplayEntry();
                    }
            }
        }
         else if (displayPromptIndex == 2)
        {
            if (_temporary.Count == 0)
            {
                Console.WriteLine("Please Load a file.");

            }
            else 
            {
                foreach (Entry entries in _temporary)
                {
                    entries.DisplayEntry();
                }
            }
            
        }
    }
    
    public void SaveToFile (List<Entry> entry)
    {

        if (File.Exists(_fileName))
        {
            using StreamWriter updateFile = File.AppendText(_fileName);
            foreach (Entry a in entry)
            {
                updateFile.WriteLine($"{a._date},{a._promptQuestion},{a._entry}");
            }
        }
        
        else 
        {
            using StreamWriter file = new(_fileName);
            foreach (Entry a in entry)

            {

                file.WriteLine($"{a._date},{a._promptQuestion},{a._entry}");
            }

        }
    }

    public List<Entry> LoadFile ()
    {

        
        List<Entry> loadEntry = new();
        
        string[] lines = System.IO.File.ReadAllLines(_loadFileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry newEntry = new()
            {
                _date = parts[0],
                _promptQuestion = parts[1],
                _entry = parts[2]
            };

            loadEntry.Add(newEntry);

        }
        return loadEntry;
    }
   
        

        
}
        

