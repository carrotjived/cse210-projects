public class ReflectingActivity : Activity
{
    private List<string> _randomPrompt = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _randomQuestion = new(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectingActivity(int duration) : base(duration)
    {
        ReflectActivity(duration);
    }

    

    public void ReflectActivity(int duration)
    {
        Console.Clear();
        Console.WriteLine("Get ready");
        StringSpinner();

        Console.WriteLine("Consider the following Prompt: \n");

        List<string> prompts = AvailablePrompts();

        DisplayPrompt(prompts);
        Console.WriteLine("\nWhen you have something in mind, press enter to continue. \n");
        Console.Read();
        Console.WriteLine("You may begin in: ");
        NumberCountdown();
        Console.Clear();

        
       
        DateTime end = GetStartTime().AddSeconds(duration);

        List<string> question = AvailableQuestions();
        while (GetStartTime() < end)
        {
            
            DisplayQuestions(question);
            DotCountdown(2);
            Console.Write("\n");
        }





        
    

        

    }

    public List<string> AvailablePrompts()
    {
        List<string> availablePrompts = new();
        foreach(string a in _randomPrompt){
            availablePrompts.Add(a);
        }
        return availablePrompts;

    }
    public void DisplayPrompt (List<string> available)
    {   
        if (available.Count == 0)
        {
            available = AvailablePrompts();
        }
        
        Random randomIndex = new();
        int index = randomIndex.Next(available.Count);
        var prompt = available[index];
        available.RemoveAt(index);
        Console.WriteLine($"--- {prompt} ---");

    }

    public List<string> AvailableQuestions() 
    {
        List<string> availableQuestions = new();
        foreach(string a in _randomQuestion)
        {
            availableQuestions.Add(a);
        }
        return availableQuestions;
    }

    

    public void DisplayQuestions(List<string> available){
        if (available.Count == 0)
        {
            available = AvailableQuestions();
        }
        Random randomIndex = new();
        int index = randomIndex.Next(available.Count);
        string question = available[index];
        available.RemoveAt(index);
        Console.WriteLine($">{question}");


    }
}

