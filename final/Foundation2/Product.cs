public class Product{
    private string _productName;
    private int _productID;
    private int _price;
    private int _quantity;

    public Product(string productName, int productID, int price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;

    }

    public int CalculatedPrice()
    {
        int price = _price * _quantity;
        return price;
    }

    public string GetProductDetails()
    {
        return $"Name: {_productName}   Product ID: {_productID}";
    }


}