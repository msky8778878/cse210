using System;

public class Running : Activity
{
    private float _distance;

    public Running(string date, int length, float distance) : base(date, length)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        float speed = GetDistance() / GetLength() * 60.0f;

        return speed;
    }

    public override float GetPace()
    {
        float pace = 60.0F / GetSpeed();

        return pace;
    }

    public override string GetInfo()
    {
        return "Running";
    }
}