public class Order
{
    //private variables
    private List<Product> _products;
    private Customer _customer;

    //constructor
    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public Order()
    {
        _products = new List<Product>();
    }
    public void OrderItem(string name, string productID, double price, int quantity)
    {     
        Product product = new Product(name, productID, price, quantity);   
        _products.Add(product);
    }    
    
    // public void OrderItem(Product product)
    // {        
    //     _products.Add(product);
    // }

    public void SetCustomer(string name, string street, string city, string state, string country)
    {
        _customer = new Customer(name, street, city, state, country);  
    }
    public string GetPackingLabel()
    {
        string productReturn = "";
        foreach(Product product in _products)
        {        
            string prod1 = $"{product.GetProductID()}: {product.GetName()}  -- price: ${product.GetPrice()} Qty: {product.GetQuantity()} ${product.GetOrderPrice()}\n";
            productReturn += prod1;
        }
        
        return productReturn;
    }

    public string GetShippingLabel()
    {
        return "";
    }

    public float GetTotalPrice()
    {
        //if customer in USA add $5 shipping, else add $35 shipping
        return -1;
    }

    public void PrintPackingLabel()
    {
        //get packing label, include product name & ID
    }

    public void PrintShippingLabel()
    {
        //get shipping address, add customer name & address
    }

}