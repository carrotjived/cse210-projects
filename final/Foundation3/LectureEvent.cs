public class LectureEvent : Event{
    private string _speaker;
    private int _capacity;
    

    public LectureEvent(string speaker, int capacity,string eventType,string eventTitle, string description,string street, string city, string stateProvince, string country, int day, string month, int year, int hour, int minute) : base(eventType,eventTitle,description,street, city, stateProvince, country, day, month, year, hour, minute)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void LectureStandardDetails()
    {
        Console.WriteLine($"What: {GetEventTitle()} - {GetEventType()}\nWhy: {GetEventDescription()}\nWhen: {GetEventDateTime()}\nWhere: {GetEventAddress()}");
    }

    public void LectureFullDetails()
    {
        LectureStandardDetails();
        Console.WriteLine($"\n\nSpeaker: {_speaker}\nCapacity: {_capacity}");

    }

    public void LectureShortDescription()
    {
       Console.WriteLine($"What: {GetEventTitle()} - {GetEventType()}\nWhen: {GetEventDateTime()}");
    }
}