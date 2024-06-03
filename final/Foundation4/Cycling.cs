using System;

public class Cycling : Activity
{
    private float _speed;

    public Cycling(string date, int length, float speed) : base(date, length)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        float distance = GetSpeed() * GetLength() / 60.0F;

        return distance;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetPace()
    {
        float pace = 60.0F / GetSpeed();

        return pace;
    }

    public override string GetInfo()
    {
        return "Cycling";
    }
}