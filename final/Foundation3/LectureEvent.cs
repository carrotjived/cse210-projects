public class LectureEvent : Event{
    private string _speaker;
    private int _capacity;
    

    public LectureEvent(string speaker, int capacity,string eventTitle, string description,string street, string city, string stateProvince, string country, int day, string month, int year, int hour, int minute) : base(eventTitle,description,street, city, stateProvince, country, day, month, year, hour, minute)
    {
        _speaker = speaker;
        _capacity = capacity;
        SetEventType("Lecture Event");
    }


    

    public void LectureFullDetails()
    {
        StandardDetail();
        Console.WriteLine($"Speaker: {_speaker}\nCapacity: {_capacity}\n\n");

    }

   
}