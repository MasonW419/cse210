using System;

class RunningAct : Activity
{
    private double _speed;
    public RunningAct(string type, string date, double length, double speed)
        : base(type, date, length)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return (_speed / 60) * GetLength();
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
}
