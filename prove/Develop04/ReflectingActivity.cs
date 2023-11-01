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
    public ReflectingActivity(int prompt) : base(prompt)
    {
    }

    public void ReflectActivity()
    {
        Console.Clear();
        Console.WriteLine("Get ready");
        StringSpinner();

    }

    public List<string> AvailablePrompts()
    {
        List<string> availablePrompts = new();
        foreach(string a in _randomPrompt){
            availablePrompts.Add(a);
        }
        return availablePrompts;

    }
    public string RandomPrompt ()
    {
        List<string> availablePrompts = AvailablePrompts();
        Random randomIndex = new();
        int index = randomIndex.Next(availablePrompts.Count());
        var prompt = availablePrompts[index];
        availablePrompts.RemoveAt(index);
        return prompt;
        
    }
}

