using System;

public class Assignment
{
    protected string _studentName;
    private string _topic;

    public Assignment(string sn, string t)
    {
        _studentName = sn;
        _topic = t;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}