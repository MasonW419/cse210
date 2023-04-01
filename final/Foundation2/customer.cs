using System;

class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, string street, string city, string state, string zip, string country)
    {
        _name = name;
        _address = new Address(street, city, state, country, zip);
    }
    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.GetAddress();
    }
    public bool IsUSA()
    {
        return _address.IsUSA();
    }
}