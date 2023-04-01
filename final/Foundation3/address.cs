using System;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private string _zip;
    public Address(string street, string city, string state, string country, string zip)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _zip = zip;
    }
    public string GetAddress()
    {
        return $"{_street} \r\n    {_city}, {_state} {_zip} \r\n    {_country}";
    }
}