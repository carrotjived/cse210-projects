public class ListingActivity : Activity
{
    private List<string> _randomPrompt = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _entries;


    public ListingActivity(int duration) : base(duration)
    {
        ListActivity(duration);
    }

    public void ListActivity(int duration)
    {
        Console.Clear();
        Console.WriteLine("Get ready");
        StringSpinner();
        Console.WriteLine("\nList as many responses you can to the following prompt: \n");
        List<string> listPrompts = ListAvailablePrompts();
        ListDisplayPrompt(listPrompts);
        Console.WriteLine("\nYou may begin in: \n");
        NumberCountdown();

        DateTime end = StartTime().AddSeconds(duration);
        List<string> entries = new();
        while (DateTime.Now < end)
        {
            Console.Write(">");
            string entry = Console.ReadLine();
            entries.Add(entry);
        }

        SetEntries(entries);

        Console.WriteLine($"\nYou have listed {CountElements(GetEntries())}");
    }

    public List<string> ListAvailablePrompts()
    {
        List<string> availablePrompts = new();
        foreach (string b in _randomPrompt)
        {
            availablePrompts.Add(b);
        }
        return availablePrompts;
    }

    public void ListDisplayPrompt(List<string> available)
    {
        if (available.Count == 0)
        {
            available = ListAvailablePrompts();
        }

        Random randomIndex = new();
        int index = randomIndex.Next(available.Count);
        var prompt = available[index];
        available.RemoveAt(index);
        Console.WriteLine($"--- {prompt} ---");

    }

    public int CountElements(List<string> entries)
    {
        return entries.Count;
    }

    public void SetEntries(List<string> entry)
    {
        _entries = entry;
    }

    public List<string> GetEntries()
    {
        return _entries;
    }

}
