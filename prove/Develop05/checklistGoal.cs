using System;

class ChecklistGoal : Goal
{
    private int _maxChecks;
    private int _bonus;
    public ChecklistGoal(int type, string name, string description, int points, int max, int bonus)
        :base(type, name, description, points)
    {
        _maxChecks = max;
        _bonus = bonus;
    }
    public ChecklistGoal(int type, string name, string description, int points, int checks, int max, int bonus)
        :base(type, name, description, points, checks)
    {
        _maxChecks = max;
        _bonus = bonus;
    }
    public override bool IsComplete()
    {
        bool complete = false;
        if(GetChecks() == _maxChecks)
        {
            complete = true;
        }
        return complete;
    }
    public override string DisplayGoal()
    {
        return $"{GetName()} ({GetDescript()}) -- Currently completed: {GetChecks()}/{_maxChecks}";
    }
    public override int GetBonus()
    {
        return _bonus;
    }
    public override string RetrieveInfo()
    {
        return $"{GetGoalType()},{GetName()},{GetDescript()},{GetPoints()},{GetChecks()},{_maxChecks},{_bonus}";
    }
}