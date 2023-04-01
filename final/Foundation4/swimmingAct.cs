using System;

class SwimmingAct : Activity
{
    private double _laps;
    public SwimmingAct(string type, string date, double length, double laps)
        : base(type, date, length)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return (_laps * 50) / 1000;
    }
    public override double GetSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }
    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
}