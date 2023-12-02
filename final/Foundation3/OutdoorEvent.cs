public class OutdoorEvent : Event
{

    private string _weather;

    public OutdoorEvent(string weather, string eventType, string eventTitle, string description, string street, string city, string stateProvince, string country, int day, string month, int year, int hour, int minute) : base(eventType,eventTitle, description, street, city, stateProvince, country, day, month, year, hour, minute)
    {
        _weather = weather;
    }

    public void ReceptionStandardDetails()
    {
        Console.WriteLine($"What: {GetEventTitle()} - {GetEventType()}\nWhy: {GetEventDescription()}\nWhen: {GetEventDateTime()}\nWhere: {GetEventAddress()}");
    }

    public void ReceptionFullDetails()
    {
        ReceptionStandardDetails();
        Console.WriteLine($"Weather Condition: {GetWeatherForecast()}");
    }


    public void ReceptionShortDescription()
    {
        Console.WriteLine($"What: {GetEventTitle()} - {GetEventType()}\nWhen: {GetEventDateTime()}");
    }

    public string GetWeatherForecast()
    {
        string weatherForecast = "";
        if (_weather == "Good Weather")
        {
            weatherForecast =  _weather;
        }
        else if (_weather == "Unpredictable Weather")
        {
            weatherForecast =  $"{_weather} - Caution should be considered when attending";
        }

        else if (_weather == "Bad Weather")
        {
            weatherForecast =  $"{_weather} - Reconsider attending for safety. Announcement shall be made soon";
        }
        return weatherForecast;
    }
}