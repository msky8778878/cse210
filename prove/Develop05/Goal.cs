using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public abstract int RecordEvent();

    protected abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string checkbox = " ";
        if (IsComplete()) checkbox = "X";

        return $"[{checkbox}] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
}