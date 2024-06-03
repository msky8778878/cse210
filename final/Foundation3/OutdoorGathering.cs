using System;

public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string GetFullDetails()
    {
        string text = GetStandardDetails();

        text += "\n" + _weather;

        return text;
    }

    public override string GetShortDescription()
    {
        string text = "Outdoor Gathering";

        text += "\n" + GetTitle() + "\n" + GetDate();

        return text;
    }
}