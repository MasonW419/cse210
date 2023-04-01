using System;

class Gathering : Event
{
    private string _weather;
    private int _temperature;
    public Gathering(string type, string title, string desc, string date, string time, Address address, string weather, int temp)
        : base(type, title, desc, date, time, address)
    {
        _weather = weather;
        _temperature = temp;
    }
    public override string GetFullDetails()
    {
        string[] info = GetInfo();
        string label = "Upcoming Event: \r\n";
        label = AddLine(label, $"{info[0]} ");
        label = AddLine(label, $"{info[1]} ");
        label = AddLine(label, $"    {info[2]}.");
        label = AddLine(label, $"    Starts on {info[3]} at {info[4]}");
        label = AddLine(label, $"Located at: ");
        label = AddLine(label, $"    {GetAddress().GetAddress()}");
        label = AddLine(label, $"Weather Forecast: ");
        label = AddLine(label, $"    {_weather} Temp: {_temperature}");
        return label;
    }
}