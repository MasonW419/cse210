using System;

class SimpleGoal : Goal
{
    public SimpleGoal(int type, string name, string description, int points)
        :base(type, name, description, points)
    {

    }
    public SimpleGoal(int type, string name, string description, int points, int checks)
        :base(type, name, description, points, checks)
    {

    }
    public override bool IsComplete()
    {
        bool complete = false;
        if(GetChecks() > 0)
        {
            complete = true;
        }
        return complete;
    }
}