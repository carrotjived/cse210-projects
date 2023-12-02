public class Event
{
    private string _eventTitle;
    private string _description;
    private Address _address;
    private DateAndTime _dateTime;

    private string _eventType;

    public Event(string eventType, string eventTitle, string description, string street, string city, string stateProvince, string country, int day, string month, int year, int hour, int minute)
    {
        _eventType = eventType;
        _eventTitle = eventTitle;
        _description = description;
        _address = new(street, city, stateProvince, country);
        _dateTime = new(day, month, year, hour, minute);

    }

    public string GetEventTitle()
    {
        return _eventTitle;
    }

    public string GetEventDescription()
    {
        return _description;
    }

    public string GetEventAddress()
    {
        return _address.GetAddress();
    }

    public string GetEventDateTime()
    {
        return _dateTime.GetDateTime();
    }

    public string GetEventType()
    {
        return _eventType;
    }

}