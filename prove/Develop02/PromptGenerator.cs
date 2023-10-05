
        
public class PromptGenerator 
{
    public List<string> _questions = new();
    public string _returnQuestion;

    public void DisplayPromptQuestion () 
    {
        Random _entryQuestion = new();
        int _index = _entryQuestion.Next(_questions.Count);
        _returnQuestion = (_questions[_index]);
        Console.WriteLine(_returnQuestion);
    }
}