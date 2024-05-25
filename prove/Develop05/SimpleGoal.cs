using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, string points, string isComplete) : base(name, description, int.Parse(points))
    {
        _isComplete = bool.Parse(isComplete);
    }

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _isComplete = true;
            return _points;
        }
        else return 0;
    }

    protected override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}