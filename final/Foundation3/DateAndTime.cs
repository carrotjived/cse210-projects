public class DateAndTime
{
    private int _day;
    private string _month;
    private int _year;
    private int _hour;
    private int _minute;

    public DateAndTime(int day, string month, int year, int hour, int minute)
    {
        _day = day;
        _month = month;
        _year = year;
        _hour = hour;
        _minute = minute;
    }

    public string GetDateTime()
    {
        if (_minute == 0)
        {

            return $"{_day} {_month} {_year} - {_hour}:00";
        }
        else
        {

            return $"{_day} {_month} {_year} - {_hour}:{_minute}";
        }

    }
}