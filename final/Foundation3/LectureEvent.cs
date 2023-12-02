public class LectureEvent : Event{
    private string _speaker;
    private int _capacity;
    

    public LectureEvent(string speaker, int capacity,string eventTitle, string description,string street, string city, string stateProvince, string country, int day, string month, int year, int hour, int minute) : base(eventTitle,description,street, city, stateProvince, country, day, month, year, hour, minute)
    {
        _speaker = speaker;
        _capacity = capacity;
        SetEventType("Lecture Event");
    }


    public void LectureStandardDetails()
    {
        Console.WriteLine($"What: {GetEventTitle()} - {GetEventType()}\nWhy: {GetEventDescription()}\nWhen: {GetEventDateTime()}\nWhere: {GetEventAddress()}\n\n");
    }

    public void LectureFullDetails()
    {
        Console.WriteLine($"What: {GetEventTitle()} - {GetEventType()}\nWhy: {GetEventDescription()}\nWhen: {GetEventDateTime()}\nWhere: {GetEventAddress()}");

        Console.WriteLine($"Speaker: {_speaker}\nCapacity: {_capacity}\n\n");

    }

    public void LectureShortDescription()
    {
       Console.WriteLine($"What: {GetEventTitle()} - {GetEventType()}\nWhen: {GetEventDateTime()}\n\n");
    }
}