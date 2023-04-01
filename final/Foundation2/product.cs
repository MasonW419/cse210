using System;

class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private double _quantity;
    public Product(string name, string productID, double price, double quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    public double TotalPrice()
    {
        return _price * _quantity;
    }
    public string GetNameAndId()
    {
        return $"Product Name: {_name} Product ID: {_productID}";
    }
}