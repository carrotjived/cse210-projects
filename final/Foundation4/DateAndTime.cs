public class DateAndTime
{
    private int _day;
    private string _month;
    private int _year;

    public DateAndTime(int day, string month, int year)
    {
        _day = day;
        _month = month;
        _year = year;
    }

    public string GetDateTime()
    {
        return $"{_day} {_month} {_year}";
    }
}