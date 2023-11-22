public class Address{

    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    private bool _countryCheck = false;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
        CountryCheck(country);
    }

    public void CountryCheck(string country)
    {
        if (country == "United States of America")
        {
            _countryCheck = true;
        }
        else
        {
            _countryCheck = false;
        }
    }

    public bool GetCheck()
    {
        return _countryCheck;
    }

    public string GetAddress()
    {
        return $"{_street}, {_city}\n{_stateProvince}\n{_country}";
    }

}