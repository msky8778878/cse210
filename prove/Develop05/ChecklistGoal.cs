using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, string points, string target, string bonus, string amountCompleted) : base(name, description, int.Parse(points))
    {
        _target = int.Parse(target);
        _bonus = int.Parse(bonus);
        _amountCompleted = int.Parse(amountCompleted);
    }

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
            if (_amountCompleted == _target) return _points + _bonus;
            else return _points;
        }
        else return 0;
    }

    protected override bool IsComplete()
    {
        if (_amountCompleted < _target) return false;
        else return true;
    }

    public override string GetDetailsString()
    {
        string checkbox = " ";
        if (IsComplete()) checkbox = "X";

        return $"[{checkbox}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";
    }
}