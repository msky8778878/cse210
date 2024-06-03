using System;

public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public override string GetFullDetails()
    {
        string text = GetStandardDetails();

        text += "\n" + _email;

        return text;
    }

    public override string GetShortDescription()
    {
        string text = "Reception";

        text += "\n" + GetTitle() + "\n" + GetDate();

        return text;
    }
}