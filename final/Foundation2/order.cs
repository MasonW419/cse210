using System;

class Order
{
    private Customer _customer;
    private List<Product> _products;
    public Order(string name, string street, string city, string state, string zip, string country)
    {
        _customer = new Customer(name, street, city, state, zip, country);
        _products = new List<Product>();
    }
    public bool AddProduct(string name, string id, double price, double quantity)
    {
        _products.Add(new Product(name, id, price, quantity));
        return true;
    }
    public double TotalCost()
    {
        double total = 0;
        foreach(Product p in _products)
        {
            total = total + p.TotalPrice();
        }
        if(_customer.IsUSA())
        {
            total = total + 5;
        }
        else
        {
            total = total + 35;
        }
        return total;
    }
    public string GetPackingLabel()
    {
        string label = "    ";
        foreach(Product p in _products)
        {
            label = label + p.GetNameAndId() + "\r\n    ";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        string label = $"    {_customer.GetName()}\r\n";
        label = label + "    " + _customer.GetAddress() + "\r\n";
        return label;
    }
}
