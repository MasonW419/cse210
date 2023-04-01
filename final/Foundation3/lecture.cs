using System;

class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string type, string title, string desc, string date, string time, Address address, string speaker, int cap)
        : base(type, title, desc, date, time, address)
    {
        _speaker = speaker;
        _capacity = cap;
    }
    public override string GetFullDetails()
    {
        string[] info = GetInfo();
        string label = "Upcoming Event: \r\n";
        label = AddLine(label, $"{info[0]} ");
        label = AddLine(label, $"{info[1]} ");
        label = AddLine(label, $"Speaker: {_speaker}");
        label = AddLine(label, $"Capacity: {_capacity}");
        label = AddLine(label, $"    {info[2]}.");
        label = AddLine(label, $"    Starts on {info[3]} at {info[4]}");
        label = AddLine(label, $"Located at: ");
        label = AddLine(label, $"    {GetAddress().GetAddress()}");
        return label;
    }
}