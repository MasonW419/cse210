using System;

class Goal
{
    private string _name;
    private int _type;
    private string _description;
    private int _points;
    private int _checks;
    public Goal(int type, string name, string description, int points)
    {
        _name = name;
        _type = type;
        _description = description;
        _points = points;
    }
    public Goal(int type, string name, string description, int points, int checks)
    {
        _name = name;
        _type = type;
        _description = description;
        _points = points;
        _checks = checks;
    }

    public string GetName()
    {
        return _name;
    }
    public int GetGoalType()
    {
        return _type;
    }
    public string GetDescript()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public int GetChecks()
    {
        return _checks;
    }
    public void SetChecks(int num)
    {
        _checks = num;
    }
    public virtual void AddCheck(int add)
    {
        _checks++;
    }
    public virtual void RecordCheck()
    {
        Console.WriteLine("Got used instead");
    }
    public virtual int GetBonus()
    {
        return 0;
    }
    public virtual bool IsComplete()
    {
        bool complete = false;
        if(_checks > 0)
        {
            complete = true;
        }
        return complete;
    }
    public virtual string DisplayGoal()
    {
        return $"{_name} ({_description})";
    }
    public virtual string RetrieveInfo()
    {
        return $"{_type},{_name},{_description},{_points},{_checks}";
    }
}