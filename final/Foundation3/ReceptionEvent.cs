public class ReceptionEvent : Event
{
    private string _emailRegistration;

    public ReceptionEvent(string emailRegistration, string eventType, string eventTitle, string description, string street, string city, string stateProvince, string country, int day, string month, int year, int hour, int minute) : base(eventType, eventTitle, description, street, city, stateProvince, country, day, month, year, hour, minute)
    {
        _emailRegistration = emailRegistration;
    }

    public void ReceptionStandardDetails()
    {
        Console.WriteLine($"What: {GetEventTitle()} - {GetEventType()}\nWhy: {GetEventDescription()}\nWhen: {GetEventDateTime()}\nWhere: {GetEventAddress()}");
    }

    public void ReceptionFullDetails()
    {
        ReceptionStandardDetails();
        Console.WriteLine($"\n\nRegister here: {_emailRegistration}");
    }

    public void ReceptionShortDescription()
    {
        Console.WriteLine($"What: {GetEventTitle()} - {GetEventType()}\nWhen: {GetEventDateTime()}");
    }

}