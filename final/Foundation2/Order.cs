using System.Reflection.Metadata.Ecma335;

public class Order{
    private List<Product> _product;
    private Customer _customer;

    public Order(List<Product> product, Customer customer)
    {
        _product = product;
        _customer = customer;
    }

    public string TotalPrice()
    {
        int finalPrice = 0;
        foreach(Product product in _product)
        {
            finalPrice += product.CalculatedPrice();
        }
        if (_customer.GetCountryCheck()== true)
        {
            finalPrice += 5;
        }
        else 
        {
            finalPrice += 35;
        }
        return $"${finalPrice}";
    }

    public void DisplayPackingLabel()
    {
        foreach(Product product in _product)
        {   
            Console.WriteLine(product.GetProductDetails());
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine(_customer.GetCustomerDetails());
    }
}