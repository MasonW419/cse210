using System;

class Event
{
    private string _eventType;
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    public Event(string type, string title, string desc, string date, string time, Address address)
    {
        _eventType = type;
        _eventTitle = title;
        _description = desc;
        _date = date;
        _time = time;
        _address = address;
    }
    public string[] GetInfo()
    {
        string[] s = {_eventType, _eventTitle, _description, _date, _time};
        return s;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public string AddLine(string baseString, string addString)
    {
        return baseString + addString + "\r\n";
    }
    public string GetStandardDetails()
    {
        string label = "Upcoming Event: \r\n";
        label = AddLine(label, $"{_eventTitle} ");
        label = AddLine(label, $"    {_description}.");
        label = AddLine(label, $"    Starts on {_date} at {_time}");
        label = AddLine(label, $"Located at: ");
        label = AddLine(label, $"    {_address.GetAddress()}");
        return label;
    }
    public virtual string GetFullDetails()
    {
        string label = "Upcoming Event: \r\n";
        label = AddLine(label, $"{_eventTitle} ");
        label = AddLine(label, $"{_eventType} ");
        label = AddLine(label, $"    {_description}.");
        label = AddLine(label, $"    Starts on {_date} at {_time}");
        label = AddLine(label, $"Located at: ");
        label = AddLine(label, $"    {_address.GetAddress()}");
        return label;
    }
    public string GetShortDetails()
    {
        string label = "Upcoming Event: \r\n";
        label = AddLine(label, $"{_eventTitle} ");
        label = AddLine(label, $"{_eventType} ");
        label = AddLine(label, $"    Starts on {_date}");
        return label;
    }
}