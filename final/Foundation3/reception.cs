using System;

class Reception : Event
{
    private string _email;
    public Reception(string type, string title, string desc, string date, string time, Address address, string email)
        : base(type, title, desc, date, time, address)
    {
        _email = email;
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
        label = AddLine(label, $"Email us at: {_email}");
        return label;
    }
}