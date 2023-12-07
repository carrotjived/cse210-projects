public class ReceptionEvent : Event
{
    private string _emailRegistration;

    public ReceptionEvent(string emailRegistration, string eventTitle, string description, string street, string city, string stateProvince, string country, int day, string month, int year, int hour, int minute) : base(eventTitle, description, street, city, stateProvince, country, day, month, year, hour, minute)
    {
        _emailRegistration = emailRegistration;
        SetEventType("Reception Event");
    }

   

    public void ReceptionFullDetails()
    {
        StandardDetail();
        Console.WriteLine($"Register here: {_emailRegistration}\n\n");
    }

    

}