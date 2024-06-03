using System;

public abstract class Activity
{
    private string _date;
    private int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public int GetLength()
    {
        return _length;
    }

    public virtual float GetDistance()
    {
        return 0.0F;
    }
    public virtual float GetSpeed()
    {
        return 0.0F;
    }
    public virtual float GetPace()
    {
        return 0.0F;
    }

    public virtual string GetInfo()
    {
        return "Activity";
    }

    public string GetSummary()
    {
        return $"{_date} {GetInfo()} ({_length} min): Distance: {GetDistance().ToString()} km, Speed: {GetSpeed().ToString()} kph, Pace: {GetPace().ToString()} min per km";
    }
}