public class OutdoorEvent : Event
{

    private string _weather;

    public OutdoorEvent(string weather, string eventTitle, string description, string street, string city, string stateProvince, string country, int day, string month, int year, int hour, int minute) : base(eventTitle, description, street, city, stateProvince, country, day, month, year, hour, minute)
    {
        _weather = weather;
        SetEventType("Outdoor Event");
    }

    public void OutdoorStandardDetails()
    {
        Console.WriteLine($"\n\nWhat: {GetEventTitle()} - {GetEventType()}\nWhy: {GetEventDescription()}\nWhen: {GetEventDateTime()}\nWhere: {GetEventAddress()}\n\n");
    }

    public void OutdoorFullDetails()
    {
        Console.WriteLine($"What: {GetEventTitle()} - {GetEventType()}\nWhy: {GetEventDescription()}\nWhen: {GetEventDateTime()}\nWhere: {GetEventAddress()}");

        Console.WriteLine($"Weather Condition: {GetWeatherForecast()}\n\n");
    }


    public void OutdoorShortDescription()
    {
        Console.WriteLine($"What: {GetEventTitle()} - {GetEventType()}\nWhen: {GetEventDateTime()}");
    }

    public string GetWeatherForecast()
    {
        string weatherForecast = "";
        if (_weather == "Good Weather")
        {
            weatherForecast = _weather;
        }
        else if (_weather == "Unpredictable Weather")
        {
            weatherForecast = $"{_weather} - Caution should be considered when attending";
        }

        else if (_weather == "Bad Weather")
        {
            weatherForecast = $"{_weather} - Reconsider attending for safety. Announcement shall be made soon";
        }
        return weatherForecast;
    }
}