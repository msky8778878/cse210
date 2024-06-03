using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        string text = GetStandardDetails();

        text += "\n" + _speaker + "\n" + _capacity.ToString();

        return text;
    }

    public override string GetShortDescription()
    {
        string text = "Lecture";

        text += "\n" + GetTitle() + "\n" + GetDate();

        return text;
    }
}