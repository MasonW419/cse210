using System;

class EternalGoal : Goal
{
    public EternalGoal(int type, string name, string description, int points)
        :base(type, name, description, points)
    {

    }
    public EternalGoal(int type, string name, string description, int points, int checks)
        :base(type, name, description, points, checks)
    {

    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string DisplayGoal()
    {
        return $"{GetName()} ({GetDescript()}) -- Times completed: {GetChecks()}";
    }
}