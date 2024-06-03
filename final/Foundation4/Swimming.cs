using System;

public class Swimming : Activity
{
    private int _lapsNumber;

    public Swimming(string date, int length, int lapsNumber) : base(date, length)
    {
        _lapsNumber = lapsNumber;
    }

    public override float GetDistance()
    {
        float distance = _lapsNumber * 50.0f / 1000.0f;

        return distance;
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
        return "Swimming";
    }
}