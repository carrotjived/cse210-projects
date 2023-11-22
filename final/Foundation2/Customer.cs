using System.Net.Sockets;

public class Customer{
    private string _name;
    private Address _address;
    private bool _inAmerica;
    

    

    public Customer(string name, string street, string city, string stateProvince, string country)
    {   
        _address = new(street, city, stateProvince, country);
        _name = name;
       
    }

   

    public bool GetCountryCheck()
    {
        _inAmerica = _address.GetCheck();
        return _inAmerica;
    }

    public string GetCustomerDetails()
    {
        return $"\nShipped to:\n{_name}\n{_address.GetAddress()}";
    }






}
