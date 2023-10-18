public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public Product()
    {

    }

    public void SetName(string name)
    {
        _name = name;
    }
    public void SetProductID(string productID)
    {
        _productID = productID;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public void SetPrice(double price)
    {
        _price = price;
    }

    public double GetPrice()
    {
        return _price;
    }
    public double GetOrderPrice()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetProductID()
    {
        return _productID;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
} //end class