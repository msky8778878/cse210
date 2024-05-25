using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public EternalGoal(string name, string description, string points) : base(name, description, int.Parse(points))
    {
    }

    public override int RecordEvent()
    {
        return _points;
    }

    protected override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}