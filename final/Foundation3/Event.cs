public class Event
{
    private string _eventTitle;
    private string _description;
    private Address _address;
    private DateAndTime _dateTime;

    private string _eventType;

    public Event(string eventTitle, string description, string street, string city, string stateProvince, string country, int day, string month, int year, int hour, int minute)
    {
       
        _eventTitle = eventTitle;
        _description = description;
        _address = new(street, city, stateProvince, country);
        _dateTime = new(day, month, year, hour, minute);

    }

    

    public void SetEventType(string eventTYpe)
    {
        _eventType = eventTYpe;
    }

    public void StandardDetail()
    {
        Console.WriteLine($"What: {_eventTitle} - {_eventType}\nWhy: {_description}\nWhen: {_dateTime.GetDateTime()}\nWhere: {_address.GetAddress()}\n");
    }

    public void ShortDescription()
    {
       Console.WriteLine($"What: {_eventTitle} - {_eventType}\nWhen: {_dateTime.GetDateTime()}\n\n");
    }

}