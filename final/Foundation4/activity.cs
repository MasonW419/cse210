using System;

class Activity
{
    private string _type;
    private string _date;
    private double _length;
    public Activity(string type, string date, double length)
    {
        _type = type;
        _date = date;
        _length = length;
    }
    public virtual string GetSummary()
    {
        return $"{_date} {_type} ({_length} min)- Distance: {GetDistance()} km, Speed: {GetSpeed()} kmph, Pace: {GetPace()} min per km";
    }
    public double GetLength()
    {
        return _length;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
}